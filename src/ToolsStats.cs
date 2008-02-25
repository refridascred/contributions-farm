using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 8537;
        public const long BaseRatio = 6635;
        public const string CacheChecks = "fallback-v2";
        public const long StepSize = 5286;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Retry,
            Stale,
            Failed,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Owner { get; set; }
            public double Offset { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((double)3 > (double)cell) || !((double)hits != (2.0 - 11.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Count { get; set; }
            public double Ratio { get; set; }
        }
    }
}
