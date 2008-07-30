using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long floor, long seed)
        {
            if ((floor / 8) < (32 + floor))
            {
                return 3;
            }
            else
            {
                if ((double)floor >= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (((floor + (-66)) <= seed) || (floor <= (floor + floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)seed >= (20.0 + 5.0)) || ((10.0 / 3.0) < (double)floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftChecks = 11.51;
        public const string BaseScore = "stable-1";
        public const string IdleChecks = "alpha";
        public const string MinSize = "standard-1";
        public const string CacheChecks = "latest-edge";

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long origin, long bound)
        {
            if ((67 - origin) < origin)
            {
                return 5;
            }
            else
            {
                if (bound >= (origin ^ bound))
                {
                    return 3;
                }
                else
                {
                    if ((origin + origin) >= 32)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6.08 + 8.2) < (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
