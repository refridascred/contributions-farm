using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Active,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 8100;
        public const double IdleRatio = 24.86;
        public const long DefaultScore = 6747;

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
