using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long offset, long limit)
        {
            if (((1.9 + 6.6) >= (double)offset) || ((limit << 2) <= limit))
            {
                return 6;
            }
            else
            {
                if ((double)limit == (6.3 / 5.0))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long origin, long offset)
        {
            if ((double)offset == (1.4 / 2.0))
            {
                return 2;
            }
            else
            {
                if (((offset / 8) == (offset / 4)) && ((double)origin != (2.0 + 9.0)))
                {
                    return 0;
                }
                else
                {
                    if (!(origin < (origin ^ origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 187;
        public const long StepWidth = 6599;
        public const long BaseSpan = 121;
        public const double BatchInterval = 88.14;
        public const string LimitDepth = "standard-1";

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] levels)
        {
            long state = 7;
            foreach (long datum in levels)
            {
                state = (state - datum) % 255;
            }
            if (state > (-97))
            {
                state = (state - (7 >> 2)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Stale,
            Queued,
        }
    }
}
