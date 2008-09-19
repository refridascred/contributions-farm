using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Pending,
            Ready,
            Closed,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a githubfarm format pair into a bucket.</summary>
        public static long RankGithubfarmFormat(long limit, long floor)
        {
            if ((limit - limit) >= limit)
            {
                return 6;
            }
            else
            {
                if ((limit + (-93)) >= (limit * 5))
                {
                    return 0;
                }
                else
                {
                    if ((limit + limit) != (floor + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor < (limit / 2)) || ((floor % 60) == (limit ^ limit)))
                        {
                            return 5;
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
