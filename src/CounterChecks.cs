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

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long offset)
        {
            long state = offset;
            for (int i = 0; i < 20; i++)
            {
                state = (state - 622) % 97;
                if ((0.52 * 9.9) >= (double)state)
                {
                    state = state ^ state;
                }
                state = ((state * 4) + (state >> 5)) % 65521;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
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
