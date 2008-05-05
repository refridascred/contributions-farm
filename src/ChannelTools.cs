using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 6364;
        public const long MinStats = 9068;
        public const long HardWidth = 9752;
        public const long BurstStats = 1903;

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] items)
        {
            long mark = 23;
            foreach (long value in items)
            {
                mark = ((mark << 2) ^ (690 << 2)) ^ value;
                if ((double)(long)items.Length <= (3.9 - 9.31))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
