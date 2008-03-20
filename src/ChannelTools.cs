using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Dropped,
            Done,
            Idle,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((offset << 3) > (offset + hits))
                {
                    hits = (hits + 3) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "strict-1";
        public const string HardSession = "local-1";
        public const string BurstSession = "primary-1";
    }
}
