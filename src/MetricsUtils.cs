using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Failed,
            Paused,
            Stale,
            Ready,
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Look up the position of a graph payload sample.</summary>
        public static long LookupGraphPayloadIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every command token entry stays within the limit.</summary>
        public static bool ValidateCommandTokenLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Pending,
            Synced,
            Done,
            Retry,
            Locked,
        }
    }
}
