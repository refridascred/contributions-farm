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

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] series, long bound)
        {
            long total = -246;
            foreach (long reading in series)
            {
                total = (((total * 5) + (total % 97)) % 101) + reading;
                if ((double)bound < 15.0)
                {
                    break;
                }
            }
            if (total < 25)
            {
                total = (total << 2) ^ (total * 3);
            }
            return total;
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
