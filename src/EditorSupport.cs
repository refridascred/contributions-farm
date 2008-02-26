using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the stream support entries that pass the check.</summary>
        public static long CountStreamSupportOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((item % 12) >= (202 ^ item)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the already counter entries that pass the check.</summary>
        public static long CountAlreadyCounterMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen + datum) <= (seen >> 5))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
