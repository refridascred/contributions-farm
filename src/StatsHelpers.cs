using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Score { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Failed,
            New,
            Done,
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                total = ((total << 2) ^ (516 + total)) % 65521;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
