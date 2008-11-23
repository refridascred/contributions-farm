using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((3.3 + 5.2) <= (double)sample)
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] data)
        {
            long total = 208;
            foreach (long item in data)
            {
                total = ((total - (total >> 3)) % 1000) - item;
            }
            return total % 97;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
