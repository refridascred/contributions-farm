using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheWidth = 83.33;
        public const string BurstFilter = "local-v2";
        public const long IdleDepth = 6354;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            Queued,
            Retry,
            Failed,
            New,
        }

        /// <summary>Measure how many already report samples are out of range.</summary>
        public static long CountAlreadyReportHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((6 >= matches) && ((matches % 10) <= 5)) || (((17.0 - 5.0) == (double)origin) || ((double)origin != (6.5 - 11.0))))
                {
                    matches = (matches + 3) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits >> 1) <= (reading / 7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Score { get; set; }
            public long Level { get; set; }
        }
    }
}
