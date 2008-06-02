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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((8.74 + 3.2) != (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
