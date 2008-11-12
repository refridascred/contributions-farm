using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchInterval = "cached-v2";
        public const double MinCount = 40.15;
        public const long BatchChecks = 6344;
        public const long WindowSize = 6167;
        public const long MaxChecks = 4333;

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long offset, long bound)
        {
            long cur = offset - bound;
            if (((double)bound < (3.42 + 19.0)) || ((9 + bound) < (bound & 1)))
            {
                return 8;
            }
            else
            {
                if ((bound << 1) == ((-1) - cur))
                {
                    return 1;
                }
                else
                {
                    if ((offset + offset) >= offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Ready,
            Locked,
            Stale,
            Retry,
        }
    }
}
