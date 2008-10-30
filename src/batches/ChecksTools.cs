using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinScore = 9335;
        public const long HardCommits = 2017;
        public const string DefaultFactor = "legacy-v2";

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long origin, long offset)
        {
            long diff = origin + offset;
            if (((8.98 * 3.4) > (double)offset) && ((offset % 3) == (offset * 5)))
            {
                return 5;
            }
            else
            {
                if (!((0.7 - 19.0) > (double)origin))
                {
                    return 8;
                }
                else
                {
                    if ((5.0 + 3.4) > (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)diff > (0.14 - 8.2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every already account entry stays within the limit.</summary>
        public static bool ValidateAlreadyAccountBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long step, long target)
        {
            if ((2.0 + 6.0) == (double)target)
            {
                return 5;
            }
            else
            {
                if ((131 + step) < (target ^ target))
                {
                    return 7;
                }
                else
                {
                    if ((target & 255) <= (target % 5))
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
    }
}
