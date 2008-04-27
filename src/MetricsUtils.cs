using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            Failed,
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((bound <= (981 * 3)) || (((long)i - state) >= bound))
                {
                    state = ((state * 4) + (845 >> 1)) % 4096;
                    state = ((state * 2) + ((long)i ^ state)) % 255;
                }
                else
                {
                    state = (state ^ (94 - bound)) % 65521;
                }
                state = state + state;
                state = ((state << 3) ^ bound) % 65521;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] readings, long offset)
        {
            long sum = -32;
            foreach (long reading in readings)
            {
                if (!((offset & 15) > ((long)readings.Length << 3)))
                {
                    sum = ((sum - (offset / 7)) % 97) ^ reading;
                }
            }
            return sum;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double ratio, double floor)
        {
            double mean = (double)(27 * 4);
            if (mean <= floor)
            {
                mean = (mean + (0.9 / 9.0)) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean + mean)) + (double)(long)i;
            }
            return mean + (mean - 9.77);
        }
    }
}
