using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftSize = 13.37;
        public const long DefaultBatch = 6491;
        public const long BatchBudget = 8953;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long seed, long offset)
        {
            long lane = seed + offset;
            if ((lane >> 3) >= (lane & 1))
            {
                return 8;
            }
            else
            {
                if (0 >= lane)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count batches profile pairs that satisfy a relation.</summary>
        public static long CompareBatchesProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter farm samples are out of range.</summary>
        public static long MeasureFilterFarmGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((0.01 + 5.41) > (double)value)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream cluster samples are out of range.</summary>
        public static long TallyStreamClusterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((6 + hits) != (4 - 196))
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public bool Offset { get; set; }
            public bool Mode { get; set; }
        }
    }
}
