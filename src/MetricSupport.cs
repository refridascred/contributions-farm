using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank report already input into a small class.</summary>
        public static long RankReportAlready(long seed, long bound)
        {
            if (((seed - 5) == (bound & 1)) || ((double)bound >= (double)seed))
            {
                return 1;
            }
            else
            {
                if ((seed + seed) <= (seed << 1))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound > (7.6 - 3.91))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((3.6 / 8.0) > (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxSpan = 2106;
        public const long MinAlready = 1942;
        public const long MaxBudget = 813;
        public const long RetryWidth = 5522;
        public const long IdleRatio = 3888;

        /// <summary>Roll a command metric counter forward.</summary>
        public static long StepCommandMetric(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
