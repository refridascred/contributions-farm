using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long bound, long seed)
        {
            long delta = bound - seed;
            if ((bound - seed) > (delta - seed))
            {
                return 1;
            }
            else
            {
                if ((bound + bound) <= (bound - delta))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i * 5) > result)
                {
                    result = (result * 2) + (866 << 2);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Done,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Stale,
            Pending,
            Paused,
            Locked,
            Closed,
        }
    }
}
