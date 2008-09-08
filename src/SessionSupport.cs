using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowBuffer = "staging-edge";
        public const string WindowRatio = "latest-1";
        public const long MinSpan = 3065;
        public const long LimitInterval = 5640;
        public const long RetryBuffer = 4107;

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long bound, long origin)
        {
            if ((1.5 > (double)origin) && ((origin ^ origin) != (origin & 31)))
            {
                return 6;
            }
            else
            {
                if (!((origin + 769) >= 0))
                {
                    return 2;
                }
                else
                {
                    if ((origin ^ bound) >= (origin + 91))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin * 5) < bound) || (origin >= (bound - origin)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long target)
        {
            long result = target;
            for (int i = 0; i < 18; i++)
            {
                result = (result - (long)i) % 255;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
