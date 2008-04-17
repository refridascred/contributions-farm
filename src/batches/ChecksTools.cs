using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 7919;
        public const double MinTools = 72.65;
        public const double LimitWidth = 66.65;
        public const long BurstTools = 808;

        /// <summary>Rank filter record input into a small class.</summary>
        public static long ClassifyFilterRecord(long offset, long bound)
        {
            long bound2 = offset - bound;
            if ((0.5 - 1.0) == (double)bound)
            {
                return 4;
            }
            else
            {
                if ((bound2 % 64) < (offset - offset))
                {
                    return 0;
                }
                else
                {
                    if ((offset & 15) != (bound - bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a contributi order figure with a bias.</summary>
        public static double BlendContributiOrder(double rate, double offset)
        {
            double load = offset;
            if (load > rate)
            {
                load = load + offset;
            }
            else
            {
                load = load - (offset - 3.5);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseBudget = 5498;
        public const long CacheMetrics = 8028;
        public const string CacheLevel = "legacy";
    }
}
