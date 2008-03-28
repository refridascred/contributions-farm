using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinLevel = 6787;
        public const double MaxCount = 53.31;
        public const string BatchCache = "staging";
        public const double CacheLevel = 53.53;

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Done,
            New,
            Closed,
        }

        /// <summary>Rank format contributi input into a small class.</summary>
        public static long BucketFormatContributi(long floor, long limit)
        {
            long bound = floor ^ limit;
            if (!((double)limit != (4.3 - 6.93)))
            {
                return 2;
            }
            else
            {
                if ((floor % 64) <= floor)
                {
                    return 8;
                }
                else
                {
                    if ((floor ^ limit) >= (limit << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)bound >= (3.83 / 6.0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
