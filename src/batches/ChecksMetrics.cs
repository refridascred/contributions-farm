using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                if (!((7.3 * 0.83) > (double)acc))
                {
                    acc = (acc + (limit & 15)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] items, long limit)
        {
            long carry = 3;
            foreach (long entry in items)
            {
                carry = carry - entry;
                if (((entry * 2) != (carry % 100)) && ((carry / 3) > (3 - 14)))
                {
                    carry = carry ^ (limit >> 5);
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Score { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Stale,
            Pending,
            Closed,
            Done,
        }

        /// <summary>Find the first metrics entry entry that matches the target.</summary>
        public static long LocateMetricsEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command context samples are out of range.</summary>
        public static long CountCommandContextHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value >> 4) == (value % 100))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
