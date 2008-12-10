using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 52.9;
        public const long CacheSize = 6150;
        public const long MaxBudget = 1316;

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] data, long seed)
        {
            long total = 15;
            foreach (long entry in data)
            {
                total = ((((total * 3) + (total & 255)) % 65521) + entry) + seed;
            }
            return total;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples, long target)
        {
            long sum = 6;
            foreach (long value in samples)
            {
                if ((double)sum <= 7.0)
                {
                    sum = ((sum ^ (sum - target)) % 101) ^ value;
                }
                else
                {
                    sum = (sum << 2) ^ target;
                }
            }
            return sum;
        }
    }
}
