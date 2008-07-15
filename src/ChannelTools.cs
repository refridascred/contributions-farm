using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((1.8 - 1.31) < (double)count)
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Paused,
            Stale,
        }
    }
}
