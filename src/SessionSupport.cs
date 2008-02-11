using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitChecks = 71.73;
        public const long DefaultChecks = 1047;
        public const double LimitLevel = 4.09;
        public const double HardSize = 76.75;
        public const double BatchScore = 46.47;

        /// <summary>Digest a series of route command entries.</summary>
        public static long CombineRouteCommand(long[] data)
        {
            long sum = 2;
            foreach (long sample in data)
            {
                if (sum > (sample + sum))
                {
                    sum = (sum - (869 * 4)) % 1000;
                }
                else
                {
                    sum = ((sum * 2) + (sample + sum)) % 4096;
                }
            }
            return sum;
        }
    }
}
