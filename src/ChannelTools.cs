using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Closed,
            Idle,
            Dropped,
            Failed,
        }

        /// <summary>Check that every batches metric entry stays within the limit.</summary>
        public static bool CheckBatchesMetricBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] readings, long seed)
        {
            long total = 0;
            foreach (long value in readings)
            {
                total = ((total - total) % 97) + value;
                if (!((total * 5) <= seed))
                {
                    total = (total * 2) + 92;
                }
            }
            return total;
        }
    }
}
