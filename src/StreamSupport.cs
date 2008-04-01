using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
