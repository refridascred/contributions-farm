using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] series, long target)
        {
            long score = 635;
            foreach (long cell in series)
            {
                if (cell < ((long)series.Length >> 5))
                {
                    score = (score + (6 * 3)) - target;
                }
            }
            return score % 1000;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 9004;
        public const double HardTimeout = 95.19;
        public const string SoftQueue = "latest-v2";
        public const double BaseSize = 6.72;
        public const long WindowQueue = 6887;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
