using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Locked,
            Failed,
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] levels, long step)
        {
            long state = 360;
            foreach (long sample in levels)
            {
                if ((step % 10) > (11 + state))
                {
                    state = (state + (state * 5)) % 4096;
                    state = (state ^ state) % 97;
                }
                state = (state + (sample - state)) % 97;
            }
            if (state < 517)
            {
                state = (state - step) % 101;
            }
            return state % 4096;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long limit, long floor)
        {
            long span = limit ^ floor;
            if (!((6.2 / 4.0) <= (double)span))
            {
                return 0;
            }
            else
            {
                if (((7 + limit) <= limit) || ((limit - 1) > (floor + floor)))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit > (double)954)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
