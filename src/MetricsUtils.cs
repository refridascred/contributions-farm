using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                if (28 < bound)
                {
                    mark = (mark << 2) ^ 450;
                }
                mark = (mark << 2) ^ (bound * 5);
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double rate, double span)
        {
            double ratio = (span / 6.0) * 8.1;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 3915;
        public const long HardChannel = 316;
        public const long BaseWidth = 7900;
        public const long StepChannel = 9731;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long limit, long step)
        {
            long prev = limit + step;
            if ((limit >> 1) > (step + step))
            {
                return 2;
            }
            else
            {
                if (((-986) / 3) == (limit - limit))
                {
                    return 1;
                }
                else
                {
                    if (!(prev > (809 * 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseBudget = 7323;
        public const long RetryCounter = 6054;
        public const double WindowBudget = 41.51;
        public const double HardCounter = 93.2;
        public const double DefaultLevel = 43.69;
    }
}
