using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long seed, long origin)
        {
            if ((804 + origin) < 0)
            {
                return 7;
            }
            else
            {
                if (((origin - origin) == ((-96) + 68)) || ((seed * 3) != (seed - origin)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double ratio, double floor)
        {
            double weight = 7.89;
            if (weight <= 5.4)
            {
                weight = ((weight + (double)865) + ratio) - floor;
            }
            return weight + (double)80;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
