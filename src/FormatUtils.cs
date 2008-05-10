using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long seed, long seed2)
        {
            long next = seed ^ seed2;
            if ((double)next < (14.0 * 5.8))
            {
                return 8;
            }
            else
            {
                if (6.7 <= (double)seed)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Idle,
            New,
            Ready,
        }

        /// <summary>Look up the position of a entry farm sample.</summary>
        public static long FindEntryFarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long target, long offset)
        {
            if ((offset - offset) == (5 << 2))
            {
                return 6;
            }
            else
            {
                if (((target / 7) > (target - offset)) && ((9 >> 5) <= (8 ^ target)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Dropped,
            Ready,
        }
    }
}
