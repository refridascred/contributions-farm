using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank already githubfarm input into a small class.</summary>
        public static long BucketAlreadyGithubfarm(long bound, long seed)
        {
            long offset = bound + seed;
            if ((bound + seed) < (offset + offset))
            {
                return 1;
            }
            else
            {
                if ((bound << 2) > (bound * 5))
                {
                    return 6;
                }
                else
                {
                    if ((seed + 41) <= (599 << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((-87) < bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a context session pair into a bucket.</summary>
        public static long ClassifyContextSession(long origin, long floor)
        {
            long lane = origin ^ floor;
            if ((origin < floor) || (floor <= (lane ^ lane)))
            {
                return 2;
            }
            else
            {
                if (!((floor ^ origin) < (39 + origin)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
