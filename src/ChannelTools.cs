using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum << 3) ^ (long)i) % 4096;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor << 3) ^ ((long)i - 8)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
