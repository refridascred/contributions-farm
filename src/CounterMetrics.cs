using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long floor, long target)
        {
            if (9.9 < (double)floor)
            {
                return 7;
            }
            else
            {
                if ((double)435 == (double)target)
                {
                    return 4;
                }
                else
                {
                    if ((7.89 - 4.5) != (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryBudget = "local-1";
        public const long BurstFactor = 966;
        public const long BaseInterval = 9426;

        /// <summary>Digest a series of cluster support entries.</summary>
        public static long DigestClusterSupport(long[] values)
        {
            long mix = 36;
            foreach (long cell in values)
            {
                mix = (mix * 4) + (235 + cell);
                if ((cell << 3) != (cell + cell))
                {
                    mix = (mix ^ mix) % 97;
                }
            }
            return mix;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
