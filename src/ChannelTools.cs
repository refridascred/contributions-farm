using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 9935;
        public const double WindowEditor = 7.46;
        public const long CacheEditor = 8445;
        public const double BaseEditor = 76.68;
        public const long MaxEditor = 3010;

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

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels)
        {
            long sum = 4;
            foreach (long sample in levels)
            {
                if (sum < (sum * 4))
                {
                    sum = (sum * 4) + (sample & 1);
                }
            }
            return sum;
        }
    }
}
