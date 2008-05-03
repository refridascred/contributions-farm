using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 4575;
        public const long StepRatio = 5928;
        public const long MaxBudget = 276;
        public const double MaxTools = 11.33;

        /// <summary>Count entry profile pairs that satisfy a relation.</summary>
        public static long CompareEntryProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Label { get; set; } = "";
            public double Owner { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                score = ((score << 3) ^ (step - score)) % 4096;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
