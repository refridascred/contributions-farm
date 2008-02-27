using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a stats batch reading.</summary>
        public static double BlendStatsBatch(double weight, double span)
        {
            double drift = weight + (span + 9.0);
            if (drift < 9.0)
            {
                drift = drift + (weight / 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - 5.98) + (double)(long)i;
            }
            return drift - 11.0;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((double)floor >= (double)504) && ((9 & 1) >= (718 ^ floor)))
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum + (sum & 15)) % 4096;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every window record entry stays within the limit.</summary>
        public static bool VerifyWindowRecordLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Size { get; set; } = "";
            public double Token { get; set; }
            public bool Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowLevel = 460;
        public const long MaxGithubfarm = 4401;
        public const string BatchCount = "legacy-edge";
        public const double IdleBudget = 36.93;
        public const string BurstSize = "legacy";
    }
}
