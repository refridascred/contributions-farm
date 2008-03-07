using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Compare every pair of stream context readings.</summary>
        public static long MatchStreamContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultScore = 49.64;
        public const double DefaultSpan = 56.21;
        public const long StepBatch = 918;
        public const long MaxInterval = 2076;
        public const long HardWidth = 8035;
    }
}
