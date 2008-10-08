using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count * 5) > (item / 8))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] levels)
        {
            long score = -889;
            foreach (long entry in levels)
            {
                if (entry < (entry - score))
                {
                    score = (score ^ (score % 8)) % 97;
                }
            }
            return score;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Flag { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of graph already readings.</summary>
        public static long OverlapGraphAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
