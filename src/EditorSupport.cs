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

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
