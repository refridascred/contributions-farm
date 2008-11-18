using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of counter context entries.</summary>
        public static long DigestCounterContext(long[] data)
        {
            long mark = 0;
            foreach (long sample in data)
            {
                if (mark < (968 + 902))
                {
                    mark = ((mark << 3) ^ (sample << 3)) % 101;
                }
            }
            if (mark < 16)
            {
                mark = (mark << 3) ^ (mark + mark);
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchSize = "standard";
        public const long DefaultQueue = 7540;
        public const string CacheQueue = "stable-v2";
        public const long CacheTimeout = 108;
        public const long LimitQueue = 6491;

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double gain, double floor)
        {
            double drift = (double)(4 & 3);
            if (drift > gain)
            {
                drift = drift + (double)337;
            }
            else
            {
                drift = drift + (double)0;
            }
            return drift + (floor * 1.2);
        }
    }
}
