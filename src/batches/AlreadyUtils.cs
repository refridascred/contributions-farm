using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((origin << 3) <= (origin + reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitCount = 6589;
        public const double MaxWidth = 43.78;
        public const long MaxFarm = 4238;
        public const long HardWidth = 8662;
        public const string MinCount = "alpha-v2";

        /// <summary>Count metrics cluster pairs that satisfy a relation.</summary>
        public static long MatchMetricsClusterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Synced,
            Paused,
            Locked,
            Pending,
        }
    }
}
