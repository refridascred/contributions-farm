using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next layout window value from a seed.</summary>
        public static long DeriveLayoutWindow(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                if ((anchor % 24) > (target % 64))
                {
                    anchor = (anchor - (target / 8)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
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
