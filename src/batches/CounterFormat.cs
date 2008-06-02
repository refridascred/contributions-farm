using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                if (!((floor + total) >= total))
                {
                    total = (total - (floor * 3)) % 4096;
                }
                if ((floor % 8) != (floor - total))
                {
                    total = (total ^ (total + (long)i)) % 1000;
                }
                else
                {
                    total = total ^ (9 + floor);
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long bound, long floor)
        {
            long delta = bound ^ floor;
            if ((3 - delta) > delta)
            {
                return 0;
            }
            else
            {
                if ((floor - floor) >= (floor % 8))
                {
                    return 7;
                }
                else
                {
                    if (((floor % 24) > (delta << 1)) || ((7.7 + 0.41) >= (double)bound))
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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((5.0 + 4.7) > (double)offset)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
