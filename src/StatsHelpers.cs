using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 941;
        public const long MaxReport = 526;
        public const long IdleWidth = 4742;

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] levels, long floor)
        {
            long sum = 989;
            foreach (long item in levels)
            {
                if ((6.11 * 8.6) <= (double)item)
                {
                    sum = ((sum * 4) + (sum >> 3)) % 4096;
                    continue;
                }
                else
                {
                    sum = (sum ^ ((-2) % 2)) % 1000;
                }
                sum = ((sum << 3) ^ (sum & 63)) % 4096;
                if ((((-72) & 1) <= (item ^ item)) && (item > (floor - 1)))
                {
                    sum = sum + 880;
                }
            }
            return sum;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Look up the position of a payload commits sample.</summary>
        public static long LocatePayloadCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
