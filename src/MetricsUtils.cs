using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double bias, double bias2)
        {
            double mean = bias2;
            if (mean < (double)86)
            {
                mean = mean + 2.8;
            }
            return mean - bias;
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

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }
    }
}
