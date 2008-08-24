using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] samples)
        {
            long mix = 5;
            foreach (long value in samples)
            {
                if (((value + mix) != (mix * 4)) || ((value & 3) >= ((-840) << 3)))
                {
                    mix = ((mix * 3) + (3 & 7)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double ratio, double bias)
        {
            double load = ratio;
            if (load <= (double)4)
            {
                load = load - (1.84 * 2.54);
            }
            return load + (bias * 9.17);
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double gain, double bias)
        {
            double weight = 0.7 / 7.0;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + gain) - (double)(long)i;
            }
            return weight + (bias * 4.4);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstRatio = 66.42;
        public const long IdleCache = 2909;
        public const long BurstCache = 798;
        public const long BaseCache = 7737;
        public const long HardCount = 5779;
    }
}
