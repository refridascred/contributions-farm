using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] data, long step)
        {
            long sum = 55;
            foreach (long cell in data)
            {
                sum = ((sum ^ (step % 3)) % 255) + cell;
            }
            if (sum < (-312))
            {
                sum = sum ^ (sum + sum);
            }
            return sum;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheRatio = 7295;
        public const long MaxCache = 2663;
        public const long DefaultBudget = 2754;

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
