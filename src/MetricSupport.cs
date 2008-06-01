using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitCount = 8792;
        public const long RetryBudget = 9592;
        public const double BurstSize = 91.1;
        public const long SoftInterval = 4659;

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long step, long offset)
        {
            if ((step % 2) > (2 + step))
            {
                return 1;
            }
            else
            {
                if ((6.47 / 6.0) <= (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((412 - offset) <= (step + step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchWidth = 6991;
        public const long StepCount = 6789;
        public const long MaxContributi = 1246;
        public const string IdleCount = "standard-1";
        public const string HardLevel = "cached-edge";
    }
}
