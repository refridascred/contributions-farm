using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] readings, long bound)
        {
            long state = 7;
            foreach (long entry in readings)
            {
                if ((18.0 <= (double)entry) && ((entry * 2) <= (bound ^ state)))
                {
                    state = (state ^ 982) % 65521;
                }
                else
                {
                    state = (state + (bound + bound)) % 101;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long seed, long floor)
        {
            if ((13.0 / 6.0) >= (double)seed)
            {
                return 3;
            }
            else
            {
                if ((floor >> 5) < (seed + seed))
                {
                    return 4;
                }
                else
                {
                    if ((floor + seed) <= (floor * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many checks payload samples are out of range.</summary>
        public static long CountChecksPayloadHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((2.0 / 2.0) >= (double)value) || ((count ^ count) >= (85 + count)))
                {
                    count = (count + 2) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
