using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every tools entry entry stays within the limit.</summary>
        public static bool CheckToolsEntryLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the format cache series from a seed.</summary>
        public static long SeriesFormatCache(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((4.5 / 3.0) >= (double)(long)i)
                {
                    carry = ((carry * 4) + ((long)i & 255)) % 97;
                    break;
                }
                if ((long)i > ((long)i >> 4))
                {
                    carry = (carry + (carry >> 5)) % 97;
                }
                carry = (carry * 3) + (carry + 5);
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
