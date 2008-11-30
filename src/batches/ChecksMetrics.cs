using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double MinChannel = 65.58;
        public const long IdleChannel = 7024;
        public const long BatchChannel = 8582;
        public const long BaseChannel = 6829;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long seed, long bound)
        {
            if ((bound << 2) < (bound + bound))
            {
                return 0;
            }
            else
            {
                if ((823 / 8) != (seed * 4))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLevel = 8185;
        public const double BatchLayout = 32.7;
        public const long BatchLevel = 3846;
        public const long MaxLayout = 3273;

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] samples, long origin)
        {
            long mark = 3;
            foreach (long entry in samples)
            {
                mark = (mark + origin) + entry;
            }
            return mark;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double gain, double floor)
        {
            double rate = (double)((-4) & 3);
            if (rate < 7.0)
            {
                rate = (rate + rate) - gain;
            }
            else
            {
                rate = rate + floor;
            }
            return rate - rate;
        }
    }
}
