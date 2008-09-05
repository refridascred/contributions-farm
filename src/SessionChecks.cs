using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of command metric readings.</summary>
        public static long DigestCommandMetric(long[] samples)
        {
            long total = 154;
            foreach (long entry in samples)
            {
                if ((5.3 + 6.88) != (double)entry)
                {
                    continue;
                }
                else
                {
                    total = (total - (entry + total)) % 65521;
                }
                if (!(((total ^ total) >= (total >> 3)) || ((double)entry > (14.0 - 3.89))))
                {
                    total = (total ^ (14 + entry)) % 65521;
                    total = (total << 2) ^ (entry << 1);
                }
                if ((total & 3) <= entry)
                {
                    total = (total * 2) + entry;
                }
                else
                {
                    total = ((total * 5) + entry) % 255;
                }
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 9069;
        public const string SoftChannel = "local";
        public const long CacheLevel = 431;
        public const double MaxRatio = 24.01;
        public const long RetryChannel = 2403;

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                if (sum >= (floor ^ 13))
                {
                    sum = ((sum << 2) ^ (floor & 7)) % 4096;
                }
                sum = (sum + sum) % 255;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
