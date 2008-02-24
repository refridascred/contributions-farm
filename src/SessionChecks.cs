using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 < (rate2 - rate))
            {
                rate2 = (rate2 - 2.6) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + 4.27) + (double)(long)i;
            }
            return rate2 - (rate2 / 2.0);
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long step, long target)
        {
            if ((target >> 1) <= (target * 5))
            {
                return 0;
            }
            else
            {
                if ((target ^ 193) > (step >> 3))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "cached-1";
        public const string MaxInterval = "legacy-edge";
        public const long IdleScore = 2192;
        public const string BatchSpan = "legacy-edge";

        /// <summary>Digest a series of stats already entries.</summary>
        public static long DigestStatsAlready(long[] data, long bound)
        {
            long score = 14;
            foreach (long item in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (((score * 4) + bound) % 97) - (long)i;
                }
                if ((item < (bound << 1)) || ((item ^ item) > (item & 3)))
                {
                    score = (score - (item << 2)) % 1000;
                }
            }
            return score;
        }
    }
}
