using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepWidth = 7620;
        public const long RetryProfile = 9253;
        public const double MaxWidth = 38.8;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Paused,
            Failed,
        }

        /// <summary>Validate layout schema readings against a bound.</summary>
        public static bool CheckLayoutSchemaBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Measure how many notes checks samples are out of range.</summary>
        public static long MeasureNotesChecksOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((7.47 + 7.0) <= (double)item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
