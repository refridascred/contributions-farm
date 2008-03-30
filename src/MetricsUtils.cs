using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
            public double Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Compare every pair of profile editor readings.</summary>
        public static long PairProfileEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count ^ count) > (sample ^ count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepDepth = 638;
        public const string DefaultProfile = "stable-v2";
        public const long RetryWidth = 2783;
        public const string IdleDepth = "stable-edge";
        public const long IdleProfile = 5277;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            Idle,
            Ready,
            Failed,
            Synced,
        }
    }
}
