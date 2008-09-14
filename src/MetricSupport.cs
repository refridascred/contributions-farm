using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double gain, double offset)
        {
            double mean = (double)929 * 9.0;
            if (mean >= (double)8)
            {
                mean = mean - (gain * 12.0);
            }
            else
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (gain + mean)) + (double)(long)i;
            }
            return mean - (gain * 6.0);
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((origin ^ mark) > (origin >> 5))
                {
                    mark = (mark << 2) ^ (mark >> 4);
                    break;
                }
                else
                {
                    mark = mark ^ ((long)i >> 5);
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleDepth = 4270;
        public const long BaseInterval = 5823;
        public const double LimitRoute = 58.4;
        public const string BurstBudget = "local-v2";
    }
}
