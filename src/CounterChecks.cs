using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] data, long offset)
        {
            long state = 44;
            foreach (long cell in data)
            {
                if ((double)111 < (double)offset)
                {
                    state = (state + cell) % 1000;
                    continue;
                }
                state = (state ^ offset) % 255;
            }
            return state;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits <= (0.12 + 3.6))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long target, long target2)
        {
            long lane = target + target2;
            if ((lane - target) < target2)
            {
                return 3;
            }
            else
            {
                if ((((-702) - 71) != (lane & 127)) && ((double)lane >= (double)target2))
                {
                    return 2;
                }
                else
                {
                    if (target > (lane % 100))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate payload account readings against a bound.</summary>
        public static bool ValidatePayloadAccountRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
