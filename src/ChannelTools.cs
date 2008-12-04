using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] readings)
        {
            long total = 29;
            foreach (long sample in readings)
            {
                total = (total + total) - sample;
            }
            return total;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Ready,
            Synced,
            Closed,
            Active,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
