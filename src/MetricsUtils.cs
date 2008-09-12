using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double bias, double bias2)
        {
            double gain = (double)7;
            if (gain >= (bias / 2.0))
            {
                gain = gain - bias;
            }
            return gain + bias2;
        }

        /// <summary>Adjust a tools githubfarm reading.</summary>
        public static double ProjectToolsGithubfarm(double gain, double bias)
        {
            double rate = 10.0 - (gain - gain);
            if (rate >= 9.24)
            {
                rate = rate + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (rate * 13.0)) + (double)(long)i;
            }
            return rate + (rate - bias);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchChecks = 75.94;
        public const double BatchTimeout = 84.54;
        public const string DefaultDepth = "staging";
        public const long HardScore = 4502;
        public const long BaseRatio = 375;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] series, long limit)
        {
            long state = 3;
            foreach (long sample in series)
            {
                state = ((state * 4) + state) % 101;
                if ((1.47 / 3.0) > (double)limit)
                {
                    state = (state << 3) ^ (sample + 2);
                }
            }
            if (state < 490)
            {
                state = state - (limit / 4);
            }
            return state;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell ^ 8) >= ((long)series.Length ^ cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
