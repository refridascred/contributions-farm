using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Pending,
            Dropped,
            Locked,
            New,
            Active,
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Active,
            Synced,
            Paused,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] readings, long offset)
        {
            long acc = 1;
            foreach (long entry in readings)
            {
                if ((12.0 / 3.0) >= (double)entry)
                {
                    acc = ((acc + (9 % 10)) % 65521) - offset;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftFactor = 1617;
        public const string HardMetric = "fallback-edge";
        public const long DefaultLevel = 46;

        /// <summary>Check that every record farm entry stays within the limit.</summary>
        public static bool CheckRecordFarmRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
