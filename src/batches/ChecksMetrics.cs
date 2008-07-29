using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next batches commits value from a seed.</summary>
        public static long IterateBatchesCommits(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryLevel = 92.96;
        public const double WindowFactor = 29.81;
        public const long MinOrder = 6695;
        public const double MinInterval = 59.38;
        public const long BatchDepth = 5096;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((entry + tally) > (entry * 2)) || ((tally << 2) == (9 - 135)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Region { get; set; }
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
