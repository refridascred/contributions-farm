using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Combine report stream values into a single score.</summary>
        public static long ScoreReportStream(long[] samples)
        {
            long sum = -1;
            foreach (long sample in samples)
            {
                if ((double)sample < (2.0 + 2.03))
                {
                    sum = (sum - (sample & 255)) % 65521;
                    sum = ((sum << 2) ^ (sample / 4)) % 65521;
                }
                sum = (sum << 2) ^ 357;
                if ((2.84 - 15.0) >= (double)sum)
                {
                    sum = (sum - sample) % 255;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "latest-edge";
        public const double StepWindow = 81.07;
        public const long CacheInterval = 671;

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 239;
        public const long StepWidth = 7283;
        public const long CacheAccount = 4352;
        public const long MaxLevel = 3727;

        /// <summary>Fold a list of report account readings.</summary>
        public static long TallyReportAccount(long[] values)
        {
            long score = 7;
            foreach (long reading in values)
            {
                if (!(score <= (score + score)))
                {
                    score = (score << 3) ^ (score << 1);
                }
                score = (score ^ (reading + reading)) % 4096;
            }
            return score % 4096;
        }
    }
}
