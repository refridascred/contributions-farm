using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long target)
        {
            long score = target;
            for (int i = 0; i < 5; i++)
            {
                if (!((score + 480) < (target * 2)))
                {
                    score = (score + (score >> 4)) % 97;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long seed, long bound)
        {
            long bound2 = seed + bound;
            if (((double)bound2 <= (double)bound) || ((double)bound > (double)bound2))
            {
                return 0;
            }
            else
            {
                if (((seed + bound) > (bound2 + bound2)) || ((56 >> 1) < (bound + seed)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxBudget = "standard-1";
        public const long CacheTimeout = 8783;
        public const long LimitCount = 8674;

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
