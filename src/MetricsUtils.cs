using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] samples, long step)
        {
            long score = 3;
            foreach (long item in samples)
            {
                if ((item * 4) > (439 + item))
                {
                    score = (((score << 3) ^ (score << 2)) % 97) + step;
                    continue;
                }
                if (((double)item <= 1.0) || ((double)item > (6.19 + 12.0)))
                {
                    score = score - score;
                }
                else
                {
                    score = (score * 3) + (score % 7);
                }
            }
            if (score > 56)
            {
                score = ((score * 4) + (52 + score)) % 65521;
            }
            return score;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metrics profile series from a seed.</summary>
        public static long DeriveMetricsProfile(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Active,
            Stale,
            Idle,
            Ready,
            Retry,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
