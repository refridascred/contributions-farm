using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Limit { get; set; }
            public double Size { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum + (floor - 248)) % 4096;
                if ((8 + sum) >= (floor - 380))
                {
                    sum = sum ^ (864 + floor);
                }
                else
                {
                    sum = sum + (sum % 100);
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Queued,
            Active,
            Synced,
            Closed,
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Stale,
            Failed,
            Ready,
            Dropped,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 4651;
        public const long BatchSize = 104;
        public const long CacheStream = 2645;
        public const long MaxStream = 9154;
        public const long DefaultStream = 7920;
    }
}
