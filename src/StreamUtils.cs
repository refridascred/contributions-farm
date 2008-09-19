using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Rank cache batch input into a small class.</summary>
        public static long RankCacheBatch(long floor, long step)
        {
            if ((floor / 8) < (step - step))
            {
                return 7;
            }
            else
            {
                if ((3.7 / 5.0) < (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Match up command graph samples.</summary>
        public static long MatchCommandGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Idle,
            Dropped,
        }
    }
}
