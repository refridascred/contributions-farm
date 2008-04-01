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

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((cell < (cell ^ hits)) && ((double)hits <= (double)21)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
