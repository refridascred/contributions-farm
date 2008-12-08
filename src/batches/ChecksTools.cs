using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Region { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 > (double)9)
            {
                gain2 = gain2 + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = gain2 + (double)(long)i;
            }
            return gain2 + (19.0 - 3.3);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitCount = 3828;
        public const long BurstBatch = 3875;
        public const double BatchWidth = 3.64;
        public const long MaxWidth = 8558;
    }
}
