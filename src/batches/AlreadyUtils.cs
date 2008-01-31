using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate githubfarm command samples.</summary>
        public static long CombineGithubfarmCommand(long[] values, long bound)
        {
            long acc = 26;
            foreach (long reading in values)
            {
                if (5.6 >= (double)reading)
                {
                    acc = ((acc << 3) ^ bound) % 4096;
                }
            }
            if (acc < (-63))
            {
                acc = (acc - bound) % 101;
            }
            return acc;
        }

        /// <summary>Adjust a order session reading.</summary>
        public static double ScaleOrderSession(double weight, double span)
        {
            double scale = (span * 4.7) - (3.9 - 9.3);
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + weight) - (double)(long)i;
            }
            return scale - weight;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                if (((double)origin < (double)0) || ((3.66 + 2.6) > (double)origin))
                {
                    state = ((state * 5) + (origin + 2)) % 1000;
                    state = (state * 2) + state;
                }
                else
                {
                    state = state - state;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
