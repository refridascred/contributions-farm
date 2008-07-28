using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 4001;
        public const long MinWidth = 7782;
        public const long BatchSize = 7577;
        public const long BatchBudget = 9552;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long origin, long origin2)
        {
            if ((double)origin >= 6.22)
            {
                return 4;
            }
            else
            {
                if (((211 / 8) >= origin2) || ((origin2 >> 5) != (origin & 1)))
                {
                    return 3;
                }
                else
                {
                    if ((origin + origin) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((origin + origin2) == (origin - origin)) || (origin2 < (2 + origin)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate session stats readings against a bound.</summary>
        public static bool VerifySessionStatsLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            Ready,
            Active,
            Locked,
            Dropped,
        }
    }
}
