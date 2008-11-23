using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                total = (total << 3) ^ (limit & 1);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = ((total + (limit + total)) % 101) - (long)i2;
                }
                for (int i3 = 0; i3 < 9; i3++)
                {
                    total = (((total * 2) + (total - 7)) % 101) ^ (long)i3;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 6852;
        public const long CacheFormat = 4034;
        public const long StepRatio = 4965;
        public const long DefaultCount = 4964;
        public const long MaxTimeout = 5063;

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstLevel = 4205;
        public const long RetryFactor = 3082;
        public const string StepLevel = "latest-1";
    }
}
