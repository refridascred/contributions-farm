using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the metric batch series from a seed.</summary>
        public static long IterateMetricBatch(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (state + (long)i2) % 1000;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 5188;
        public const long BurstSchema = 7347;
        public const double DefaultScore = 80.5;
        public const string RetryInterval = "legacy-1";

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
