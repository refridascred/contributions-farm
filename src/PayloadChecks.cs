using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            Idle,
            Pending,
            Paused,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((1.9 / 2.0) > (double)item) || (matches > target))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] samples)
        {
            long sum = 782;
            foreach (long sample in samples)
            {
                sum = sum - sample;
                if (sum >= (sum + sum))
                {
                    sum = (sum - (sample + 4)) % 4096;
                }
                if (7.8 >= (double)sum)
                {
                    break;
                }
            }
            if (sum > 945)
            {
                sum = sum - (sum + sum);
            }
            return sum % 65521;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Size { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstGithubfarm = "local";
        public const string RetryGithubfarm = "standard";
        public const string WindowSize = "strict-edge";
        public const double IdleInterval = 66.16;
        public const long MaxGithubfarm = 925;
    }
}
