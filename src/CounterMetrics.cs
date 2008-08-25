using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two queue route measurements.</summary>
        public static double ScaleQueueRoute(double gain, double offset)
        {
            double rate = (double)(13 % 24);
            if (rate >= 8.34)
            {
                rate = (rate + gain) - offset;
            }
            else
            {
                rate = rate + (9.81 / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate - gain;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 3722;
        public const long MaxGraph = 9107;
        public const long SoftWidth = 7332;
        public const long BatchGraph = 3880;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstScore = 771;
        public const long SoftFarm = 4607;
        public const long StepLevel = 2813;
        public const string CacheFarm = "open-1";

        /// <summary>Combine session payload values into a single score.</summary>
        public static long DigestSessionPayload(long[] data, long seed)
        {
            long mark = 889;
            foreach (long sample in data)
            {
                mark = (((mark ^ (mark + mark)) % 97) ^ sample) - seed;
            }
            if (mark < 165)
            {
                mark = mark ^ mark;
            }
            return mark % 1000;
        }
    }
}
