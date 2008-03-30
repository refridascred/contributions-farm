using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long floor, long origin)
        {
            long edge = floor ^ origin;
            if ((921 + edge) <= origin)
            {
                return 6;
            }
            else
            {
                if ((885 - edge) <= floor)
                {
                    return 3;
                }
                else
                {
                    if ((double)origin < (0.84 - 6.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (edge > (edge + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepAlready = 33.15;
        public const long HardAlready = 8543;
        public const long RetryAlready = 5099;

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitWidth = 3032;
        public const double WindowEntry = 56.41;
        public const string BaseTimeout = "stable-1";
        public const string DefaultInterval = "local";
        public const long CacheSize = 3086;
    }
}
