using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Stale,
            Retry,
            Draft,
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long floor, long seed)
        {
            if (seed >= (seed + floor))
            {
                return 3;
            }
            else
            {
                if (floor >= 1)
                {
                    return 2;
                }
                else
                {
                    if ((double)seed != (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)seed > 7.36) || ((double)floor != (double)seed))
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

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 2907;
        public const double LimitCount = 95.91;
        public const long BaseFilter = 182;
        public const double CacheInterval = 69.47;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 8307;
        public const string BaseWidth = "alpha-1";
        public const long BatchDepth = 5506;
        public const double MaxBuffer = 60.24;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
