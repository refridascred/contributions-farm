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

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] samples)
        {
            long carry = 55;
            foreach (long datum in samples)
            {
                if ((carry <= 3) || (carry < (datum + 28)))
                {
                    carry = (carry - datum) % 97;
                }
            }
            if (carry > 5)
            {
                carry = carry + (carry - 544);
            }
            return carry;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
        }

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
