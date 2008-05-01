using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value + count) == (41 >> 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultSize = 4005;
        public const long IdleInterval = 4064;
        public const string BatchRecord = "latest-v2";

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a farm buffer reading.</summary>
        public static double AdjustFarmBuffer(double scale, double floor)
        {
            double scale2 = (double)(43 - 6);
            if (scale2 > (floor + scale))
            {
                scale2 = scale2 + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + (scale2 + 3.6)) + (double)(long)i;
            }
            return scale2 + floor;
        }
    }
}
