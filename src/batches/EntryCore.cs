using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 38.48;
        public const double SoftLevel = 29.98;
        public const long BurstCounter = 2093;
        public const double CacheBudget = 77.91;
        public const long HardScore = 4224;

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)cell != (7.88 / 3.0))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }
    }
}
