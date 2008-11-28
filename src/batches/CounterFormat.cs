using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = ((anchor - (seed + (long)i)) % 255) - (long)i2;
                }
                if ((2.9 + 9.0) > (double)anchor)
                {
                    anchor = ((anchor << 3) ^ (anchor + anchor)) % 1000;
                    continue;
                }
                else
                {
                    anchor = (anchor ^ (97 + seed)) % 65521;
                    anchor = anchor ^ (seed + (long)i);
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
