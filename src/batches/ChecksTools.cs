using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultTimeout = 1692;
        public const double HardLevel = 50.67;
        public const long BurstFactor = 1361;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Synced,
            Closed,
            Done,
            Stale,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] values)
        {
            long state = -37;
            foreach (long entry in values)
            {
                state = state - (76 + entry);
                state = state - 453;
                if (((27 & 127) <= entry) || ((entry >> 4) > entry))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
