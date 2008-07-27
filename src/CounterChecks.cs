using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long origin, long bound)
        {
            long lane = origin - bound;
            if ((double)bound <= (3.9 - 8.6))
            {
                return 0;
            }
            else
            {
                if (!((857 / 6) == (lane + origin)))
                {
                    return 8;
                }
                else
                {
                    if (!((double)bound <= (double)origin))
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

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Synced,
            New,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryCount = "fallback";
        public const long MinGraph = 7159;
        public const string StepGraph = "latest-v2";
        public const long IdleGraph = 6045;

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheRatio = 26.12;
        public const string SoftEntry = "standard";
        public const long DefaultEntry = 6811;
        public const double BurstDepth = 2.02;
        public const double LimitEntry = 6.87;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Active,
            Locked,
            New,
        }
    }
}
