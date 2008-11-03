using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits & 7) < hits)
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Score { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up entry account samples.</summary>
        public static long OverlapEntryAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 946;
        public const string MinBuffer = "stable";
        public const long BaseBuffer = 569;
    }
}
