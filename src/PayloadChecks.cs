using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitCount = 40.67;
        public const double MaxCount = 30.13;
        public const double RetryTools = 10.46;
        public const long SoftTools = 4231;
        public const long SoftSize = 4915;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double weight, double offset)
        {
            double gain = (weight - offset) + (offset + offset);
            return gain - weight;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Label { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((87 + seen) >= (75 - floor))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Find the first batches contributi entry that matches the target.</summary>
        public static long FindBatchesContributiIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
