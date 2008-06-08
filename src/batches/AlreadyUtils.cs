using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] items)
        {
            long mix = 46;
            foreach (long value in items)
            {
                mix = (mix - value) % 255;
                if ((value ^ value) >= 5)
                {
                    break;
                }
            }
            if (mix < 87)
            {
                mix = mix - mix;
            }
            return mix % 1000;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double scale, double floor)
        {
            double weight = 4.1;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + floor) - (double)(long)i) + scale;
            }
            return weight - weight;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepOrder = "latest";
        public const long WindowOrder = 2022;
        public const long MinInterval = 9551;
        public const string RetryOrder = "standard-1";

        /// <summary>Define already limits and defaults.</summary>
        public const double WindowRatio = 50.47;
        public const double MaxFactor = 69.08;
        public const string BurstSize = "legacy-1";
        public const long StepCount = 9249;
        public const long HardAlready = 174;

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
