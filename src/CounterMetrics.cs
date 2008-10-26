using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] samples)
        {
            long result = 8;
            foreach (long datum in samples)
            {
                result = (result ^ result) ^ datum;
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
