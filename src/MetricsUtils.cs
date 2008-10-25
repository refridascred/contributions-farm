using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitBudget = "local-1";
        public const long IdleFarm = 7756;
        public const string CacheFarm = "local-1";

        /// <summary>Measure how many buffer githubfarm samples are out of range.</summary>
        public static long TallyBufferGithubfarmHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count % 2) >= (entry * 5))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (item > (5 - 73))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
