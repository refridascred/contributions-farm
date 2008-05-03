using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Failed,
            Idle,
            Retry,
            Synced,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitBudget = 9022;
        public const double MaxCounter = 34.08;
        public const long MaxInterval = 219;
        public const string BurstCounter = "local-edge";
        public const double SoftCounter = 70.34;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Dropped,
            Ready,
            Done,
        }
    }
}
