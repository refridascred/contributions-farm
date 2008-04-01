using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] readings, long step)
        {
            long result = 36;
            foreach (long entry in readings)
            {
                result = (result + step) + entry;
                result = ((result * 3) + (step - 1)) % 101;
            }
            return result;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long seed, long floor)
        {
            long edge = seed - floor;
            if (edge < (edge << 2))
            {
                return 6;
            }
            else
            {
                if ((0.1 / 4.0) > (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long bound, long bound2)
        {
            long bound3 = bound + bound2;
            if (((bound2 + bound2) >= (-550)) && (bound >= (bound2 + bound3)))
            {
                return 0;
            }
            else
            {
                if ((824 < (bound3 - bound)) || ((bound + bound) < bound3))
                {
                    return 3;
                }
                else
                {
                    if (bound3 > (bound2 + 54))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((99 ^ bound2) > (1 + bound3))
                        {
                            return 4;
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
}
