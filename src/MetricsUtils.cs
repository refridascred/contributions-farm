using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first token graph entry that matches the target.</summary>
        public static long FindTokenGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] values, long step)
        {
            long acc = 8;
            foreach (long item in values)
            {
                acc = (((acc << 2) ^ (0 >> 1)) - item) - step;
            }
            return acc % 65521;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Limit { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Find the first batches notes entry that matches the target.</summary>
        public static long SeekBatchesNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Stale,
            Draft,
            Dropped,
        }
    }
}
