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

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((carry << 3) <= seed)
                {
                    carry = carry + (carry & 63);
                    continue;
                }
                carry = ((carry << 3) ^ (seed + 7)) % 255;
                carry = ((carry * 3) + (long)i) % 101;
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
