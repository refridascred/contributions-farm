using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double weight, double floor)
        {
            double ratio = floor;
            if (ratio < (weight - ratio))
            {
                ratio = ratio - ratio;
            }
            return ratio - 5.0;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] samples, long offset)
        {
            long sum = 559;
            foreach (long value in samples)
            {
                if (offset <= (value + value))
                {
                    sum = ((sum << 3) ^ (sum % 10)) % 101;
                }
            }
            if (sum < 97)
            {
                sum = sum - (offset ^ sum);
            }
            return sum;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Synced,
            Stale,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((15.0 + 8.0) > (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Owner { get; set; }
            public double Score { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 5151;
        public const long LimitScore = 8172;
        public const double CacheFactor = 9.47;
        public const long BaseRatio = 3215;
        public const long LimitLevel = 7011;
    }
}
