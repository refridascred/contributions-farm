using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many editor batches samples are out of range.</summary>
        public static long TallyEditorBatchesOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (hits >= ((-369) ^ offset))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry ^ (carry << 2)) % 101;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 1975;
        public const long DefaultFormat = 8552;
        public const long BurstFormat = 6369;
        public const long LimitFormat = 4158;
        public const double HardFormat = 0.54;

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Flag { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
