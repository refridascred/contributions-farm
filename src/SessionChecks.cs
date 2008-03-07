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

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen ^ target) <= 48)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
