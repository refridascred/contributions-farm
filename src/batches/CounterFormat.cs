using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] items, long seed)
        {
            long state = -790;
            foreach (long item in items)
            {
                state = (((state << 2) ^ (state + state)) % 97) + item;
                state = (state - (seed + seed)) % 4096;
                if ((double)state >= (1.5 / 4.0))
                {
                    break;
                }
            }
            if (state < 38)
            {
                state = (state + (state << 3)) % 255;
            }
            return state;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
