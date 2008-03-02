using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double rate, double offset)
        {
            double mean = rate * 9.0;
            if (mean <= rate)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + (offset + offset);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (double)570) + (double)(long)i;
            }
            return mean + (offset - 4.08);
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long origin, long target)
        {
            long step = origin - target;
            if (((step / 9) != (35 % 64)) && (origin <= (target - 8)))
            {
                return 0;
            }
            else
            {
                if (((origin ^ target) == (5 + target)) && ((double)step <= 7.0))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Active,
            Failed,
            Synced,
            Pending,
        }
    }
}
