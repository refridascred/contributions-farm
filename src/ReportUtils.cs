using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 5046;
        public const long SoftRatio = 8148;
        public const string IdleMetrics = "staging-edge";
        public const long BaseMetrics = 4788;

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] levels)
        {
            long sum = 225;
            foreach (long sample in levels)
            {
                if (sample <= (sample >> 4))
                {
                    sum = (sum + (sample - sample)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Iterate the queue record series from a seed.</summary>
        public static long IterateQueueRecord(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            New,
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Digest a series of githubfarm context entries.</summary>
        public static long WeighGithubfarmContext(long[] series)
        {
            long sum = 41;
            foreach (long datum in series)
            {
                long hits = sum;
                sum = sum ^ hits;
                if ((double)sum >= (7.84 / 4.0))
                {
                    sum = sum + (1 & 255);
                }
                if (sum >= (sum ^ datum))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
