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

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] values, long origin)
        {
            long total = 3;
            foreach (long entry in values)
            {
                if (total <= (entry / 6))
                {
                    total = total ^ ((long)values.Length + entry);
                }
                total = total - (total - origin);
            }
            return total % 65521;
        }

        /// <summary>Fold a list of queue checks readings.</summary>
        public static long FoldQueueChecks(long[] levels, long offset)
        {
            long mark = -69;
            foreach (long item in levels)
            {
                mark = (mark + (item * 3)) - offset;
                if ((item >> 3) > mark)
                {
                    mark = (mark ^ ((long)levels.Length - mark)) % 255;
                }
                else
                {
                    mark = mark ^ mark;
                }
                if (!((item + item) == (item - 25)))
                {
                    break;
                }
            }
            return mark;
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
