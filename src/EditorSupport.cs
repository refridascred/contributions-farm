using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryFarm = "stable";
        public const double RetryWidth = 78.04;
        public const long BurstFarm = 2476;

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double gain, double floor)
        {
            double ratio = 8.96;
            if (ratio < gain)
            {
                ratio = (ratio + ratio) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + 20.0;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            New,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseBatches = "primary-1";
        public const long IdleTimeout = 272;
        public const long LimitBatches = 8212;

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 6054;
        public const double DefaultCount = 53.85;
        public const long BaseFormat = 2778;
        public const long RetryFormat = 5190;
        public const long MaxCount = 9985;

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
