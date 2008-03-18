using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of route profile readings.</summary>
        public static long ScoreRouteProfile(long[] levels, long limit)
        {
            long score = 3;
            foreach (long reading in levels)
            {
                if ((double)score > 8.81)
                {
                    score = ((score + (reading ^ score)) % 97) + limit;
                }
            }
            if (score > (-3))
            {
                score = ((score << 2) ^ (score >> 4)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Adjust a context payload reading.</summary>
        public static double ProjectContextPayload(double scale, double bias)
        {
            double drift = (double)(8 - 0);
            if (drift < scale)
            {
                drift = (drift + (double)376) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (double)33) - (double)(long)i;
            }
            return drift - 3.7;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "staging-edge";
        public const long IdleReport = 9687;
        public const long RetryTimeout = 4515;
        public const double BaseReport = 96.92;
    }
}
