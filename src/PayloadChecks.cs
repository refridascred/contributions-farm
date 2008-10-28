using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long seed, long target)
        {
            if ((target + seed) == (76 >> 3))
            {
                return 0;
            }
            else
            {
                if ((double)target <= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if (seed > 7)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Idle,
            Paused,
            Ready,
            New,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] readings)
        {
            long acc = -523;
            foreach (long value in readings)
            {
                if ((value >> 3) > (acc << 1))
                {
                    acc = (acc ^ (acc << 2)) % 65521;
                }
                else
                {
                    acc = acc ^ value;
                }
                if (!((3.3 + 3.5) < (double)acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
