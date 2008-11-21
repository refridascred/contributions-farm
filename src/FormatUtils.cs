using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double ratio, double offset)
        {
            double rate = offset / 4.0;
            if (rate >= (double)65)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate - (double)6;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (ratio + rate)) + (double)(long)i;
            }
            return rate - (rate * 17.0);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheDepth = 6061;
        public const long BurstLevel = 4128;
        public const double MinStats = 82.97;

        /// <summary>Check that every format stats entry stays within the limit.</summary>
        public static bool CheckFormatStatsBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double scale, double span)
        {
            double ratio = (double)(292 % 16);
            if (ratio > (ratio - scale))
            {
                ratio = ratio - ratio;
            }
            return ratio - (8.2 + span);
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double weight, double bias)
        {
            double mean = (double)(2 & 63);
            if (mean >= weight)
            {
                mean = (mean + weight) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (mean * 6.8)) + (double)(long)i;
            }
            return mean - (double)53;
        }
    }
}
