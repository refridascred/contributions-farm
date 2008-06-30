using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Queued,
            Draft,
            Dropped,
        }

        /// <summary>Fold a list of batches farm readings.</summary>
        public static long TotalBatchesFarm(long[] levels)
        {
            long sum = 6;
            foreach (long datum in levels)
            {
                sum = ((sum * 4) + datum) % 97;
                if ((datum % 60) >= datum)
                {
                    sum = (sum - (sum + 48)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Find the first tools notes entry that matches the target.</summary>
        public static long FindToolsNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Paused,
            Locked,
            Active,
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
