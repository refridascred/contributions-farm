using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] values)
        {
            long sum = 57;
            foreach (long cell in values)
            {
                if (((sum + sum) != (sum / 9)) || (sum <= (8 * 5)))
                {
                    sum = sum ^ (cell + sum);
                }
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 9618;
        public const long MaxRatio = 5311;
        public const string IdleScore = "strict-1";
        public const long CacheSpan = 2068;
        public const string BurstDepth = "staging";
    }
}
