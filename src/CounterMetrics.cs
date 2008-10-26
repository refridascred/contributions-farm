using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] items)
        {
            long result = 5;
            foreach (long entry in items)
            {
                result = ((result << 3) ^ (result * 3)) - entry;
            }
            return result;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc - ((long)i & 63)) % 65521;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = ((acc - (floor * 2)) % 101) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
