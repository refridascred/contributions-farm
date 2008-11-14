using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count profile stats pairs that satisfy a relation.</summary>
        public static long PairProfileStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm batch readings against a rule.</summary>
        public static long AuditGithubfarmBatchGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((bound - (-68)) <= (matches + bound))
                {
                    matches = (matches + 2) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Synced,
            Queued,
            Paused,
            Ready,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 6549;
        public const double MaxSpan = 8.16;
        public const double HardRatio = 64.28;
        public const double StepStream = 36.54;

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
