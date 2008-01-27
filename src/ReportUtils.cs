using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 8648;
        public const string CacheFactor = "standard-edge";
        public const long MinDepth = 8580;

        /// <summary>Iterate the metric report series from a seed.</summary>
        public static long DeriveMetricReport(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((origin % 24) <= 3) || ((sum % 97) > sum))
                {
                    sum = ((sum * 3) + 278) % 1000;
                }
                if (!((sum ^ sum) > (sum - sum)))
                {
                    sum = (sum - ((long)i / 3)) % 97;
                }
                else
                {
                    sum = ((sum << 2) ^ sum) % 1000;
                }
                if ((256 - origin) <= origin)
                {
                    sum = sum + origin;
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            Locked,
            Synced,
            Pending,
        }
    }
}
