using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit farm editor readings against a rule.</summary>
        public static long CountFarmEditorHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((double)seen <= (6.6 * 7.74)) || ((reading + limit) > (reading << 1)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
