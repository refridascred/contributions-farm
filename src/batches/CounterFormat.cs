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

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
