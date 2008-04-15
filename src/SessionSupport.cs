using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count already batches pairs that satisfy a relation.</summary>
        public static long CompareAlreadyBatchesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every counter stats entry stays within the limit.</summary>
        public static bool CheckCounterStatsRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] data)
        {
            long acc = 917;
            foreach (long cell in data)
            {
                if ((double)acc == (double)(-405))
                {
                    continue;
                }
                else
                {
                    acc = (acc - cell) % 65521;
                }
                for (int i = 0; i < 4; i++)
                {
                    acc = ((acc + (cell & 1)) % 101) - (long)i;
                }
                acc = (acc * 5) + (acc - acc);
            }
            return acc;
        }
    }
}
