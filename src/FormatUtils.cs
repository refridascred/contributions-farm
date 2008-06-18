using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Synced,
            Active,
            Locked,
            Stale,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long seed, long seed2)
        {
            if ((seed2 ^ (-151)) > seed)
            {
                return 4;
            }
            else
            {
                if ((seed2 >= (984 - seed2)) || (661 >= (seed2 + 1)))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed2 < 5.5)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!!((entry + 7) <= (matches + entry)))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryDepth = 9036;
        public const double BurstProfile = 22.77;
        public const long SoftSize = 7466;
        public const long RetryProfile = 2818;
        public const string CacheBudget = "alpha-edge";

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item & 31) > item)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
