using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long origin, long seed)
        {
            long prev = origin + seed;
            if ((double)seed == (18.0 + 6.13))
            {
                return 8;
            }
            else
            {
                if ((double)prev >= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (!((double)origin != (double)seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((prev ^ prev) >= (seed + origin)) && ((6.9 + 9.27) != (double)origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseSpan = 76.86;
        public const string SoftWidth = "local-v2";
        public const long IdleBudget = 9993;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Synced,
            Draft,
        }
    }
}
