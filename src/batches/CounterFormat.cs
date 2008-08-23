using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long floor, long bound)
        {
            long gap = floor - bound;
            if ((4 < (62 - floor)) || ((gap << 2) != (5 & 255)))
            {
                return 7;
            }
            else
            {
                if ((double)floor == (7.52 / 7.0))
                {
                    return 4;
                }
                else
                {
                    if ((floor + gap) <= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the profile metrics entries that pass the check.</summary>
        public static long MeasureProfileMetricsGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell % 100) <= (tally ^ target))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already session entries.</summary>
        public static long CombineAlreadySession(long[] samples)
        {
            long state = 8;
            foreach (long sample in samples)
            {
                state = (state - (sample + 1)) % 65521;
                if (!((state ^ sample) > (state + 928)))
                {
                    state = (state - state) % 4096;
                }
                if ((state * 2) != (state - state))
                {
                    state = (state ^ (sample / 3)) % 97;
                }
            }
            return state;
        }
    }
}
