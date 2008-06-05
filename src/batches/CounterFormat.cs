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

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor - (anchor >> 1)) % 1000;
                if ((627 - anchor) <= (target + (long)i))
                {
                    anchor = (anchor - (anchor + target)) % 255;
                    anchor = ((anchor * 3) + (target / 6)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
