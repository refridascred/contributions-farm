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

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long limit, long step)
        {
            if (!((step << 3) >= step))
            {
                return 2;
            }
            else
            {
                if ((double)step < (7.29 / 4.0))
                {
                    return 1;
                }
                else
                {
                    if (5.1 >= (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        if (step >= (limit << 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
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
