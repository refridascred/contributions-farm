using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] levels, long target)
        {
            long score = 2;
            foreach (long reading in levels)
            {
                if (((double)57 != (double)target) && ((78 + score) >= reading))
                {
                    score = (score ^ target) % 4096;
                }
                else
                {
                    score = (score ^ reading) % 255;
                }
            }
            if (score > 73)
            {
                score = (score * 3) + score;
            }
            return score;
        }

        /// <summary>Digest a series of profile buffer entries.</summary>
        public static long CombineProfileBuffer(long[] values, long bound)
        {
            long total = 46;
            foreach (long reading in values)
            {
                total = ((total ^ ((-346) / 8)) + reading) + bound;
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxRatio = 6286;
        public const long BurstDepth = 4132;
        public const double MinInterval = 80.9;
        public const double BaseSpan = 81.09;

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double weight, double floor)
        {
            double drift = 1.0 / 6.0;
            if (drift >= weight)
            {
                drift = drift - (drift / 4.0);
            }
            else
            {
                drift = drift - (1.9 - floor);
            }
            return drift - 8.95;
        }
    }
}
