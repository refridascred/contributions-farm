using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Draft,
            Closed,
            Paused,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 7728;
        public const long CacheSize = 3325;
        public const string IdleInterval = "open";
        public const string RetryAccount = "strict-v2";
        public const long SoftAccount = 8666;

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepWidth = 7078;
        public const long WindowBatches = 6195;
        public const long DefaultBatches = 5529;
        public const long BurstBatches = 4556;

        /// <summary>Roll a filter cluster counter forward.</summary>
        public static long DeriveFilterCluster(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i - (long)i) < (total + limit))
                {
                    total = ((total << 3) ^ (total & 7)) % 255;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
