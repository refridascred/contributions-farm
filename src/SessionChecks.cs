using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate session context readings against a bound.</summary>
        public static bool VerifySessionContextLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] samples)
        {
            long mark = 8;
            foreach (long value in samples)
            {
                mark = ((mark + mark) % 65521) ^ value;
            }
            return mark;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double gain, double floor)
        {
            double mean = (gain - floor) / 5.0;
            if (mean <= 7.35)
            {
                mean = mean + 8.0;
            }
            else
            {
                mean = mean - (mean * 16.0);
            }
            return mean + (gain - gain);
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double rate, double floor)
        {
            double drift = rate / 6.0;
            if (drift <= (double)34)
            {
                drift = (drift + drift) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + 10.0) + (double)(long)i;
            }
            return drift - (rate / 9.0);
        }
    }
}
