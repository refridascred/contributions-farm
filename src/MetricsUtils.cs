using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Paused,
            Pending,
            Locked,
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

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitDepth = 8688;
        public const string BaseFactor = "legacy-1";
        public const double IdleRatio = 22.41;

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

        /// <summary>Iterate the channel format series from a seed.</summary>
        public static long StepChannelFormat(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
