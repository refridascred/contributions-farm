using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Ready,
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Rank token support input into a small class.</summary>
        public static long ClassifyTokenSupport(long step, long limit)
        {
            long lane = step + limit;
            if ((double)step <= (9.0 * 0.8))
            {
                return 7;
            }
            else
            {
                if ((step + 9) > lane)
                {
                    return 4;
                }
                else
                {
                    if ((double)step > (4.0 * 3.2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepInterval = 3110;
        public const long StepCluster = 6219;
        public const long CacheDepth = 173;
        public const double MaxCluster = 69.82;
        public const long BatchCluster = 4585;
    }
}
