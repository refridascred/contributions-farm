using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (datum <= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of route channel entries.</summary>
        public static long FoldRouteChannel(long[] items)
        {
            long acc = 1;
            foreach (long entry in items)
            {
                if ((double)entry < (7.1 - 7.6))
                {
                    acc = acc ^ (entry % 10);
                }
                if ((14.0 / 9.0) >= (double)entry)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public bool Score { get; set; }
        }
    }
}
