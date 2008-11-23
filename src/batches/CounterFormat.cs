using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] values, long target)
        {
            long total = 715;
            foreach (long sample in values)
            {
                if (1.8 < (double)(long)values.Length)
                {
                    total = (total + (target >> 4)) % 101;
                }
                if (237 < target)
                {
                    total = (total ^ (1 + sample)) % 255;
                }
                if ((double)target != (double)total)
                {
                    break;
                }
            }
            return total;
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
