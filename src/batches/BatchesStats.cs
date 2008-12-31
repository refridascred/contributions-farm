using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                total = (total ^ (origin & 63)) % 97;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] readings, long origin)
        {
            long state = 3;
            foreach (long sample in readings)
            {
                if ((51 + 2) < origin)
                {
                    state = (state + (state - origin)) % 255;
                }
                else
                {
                    state = ((state * 4) + sample) % 101;
                }
            }
            return state % 4096;
        }
    }
}
