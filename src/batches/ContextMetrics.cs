using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Idle,
            New,
            Failed,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Region { get; set; }
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally * 5) < (item + seed))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of report format entries.</summary>
        public static long TotalReportFormat(long[] data)
        {
            long acc = 33;
            foreach (long entry in data)
            {
                if (entry > (entry + entry))
                {
                    acc = acc - (acc + entry);
                }
                else
                {
                    acc = acc - (entry / 2);
                }
            }
            return acc;
        }
    }
}
