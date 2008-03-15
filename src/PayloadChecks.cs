using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchReport = "stable-1";
        public const long MinReport = 9447;
        public const long DefaultSize = 3591;
        public const long HardReport = 7823;
        public const long CacheLevel = 4935;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the account farm series from a seed.</summary>
        public static long DeriveAccountFarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
