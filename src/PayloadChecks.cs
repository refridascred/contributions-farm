using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] items, long target)
        {
            long total = 8;
            foreach (long item in items)
            {
                if (!((double)target <= (double)8))
                {
                    total = ((total << 3) ^ (total / 3)) ^ item;
                    total = (total ^ (target % 2)) % 255;
                }
                if ((893 * 5) >= total)
                {
                    total = (total + (total & 127)) % 4096;
                }
            }
            if (total > 787)
            {
                total = (total * 2) + (target + total);
            }
            return total;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = ((sum ^ (sum + origin)) % 65521) - (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
