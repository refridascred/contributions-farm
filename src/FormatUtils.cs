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

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] readings, long target)
        {
            long state = 170;
            foreach (long sample in readings)
            {
                state = ((state << 2) ^ (sample + sample)) % 4096;
                if ((target + 206) < (target + target))
                {
                    state = ((state * 4) + sample) % 65521;
                }
            }
            return state;
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
