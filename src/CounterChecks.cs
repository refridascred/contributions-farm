using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double weight, double floor)
        {
            double mean = (weight + floor) + weight;
            return mean - floor;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Dropped,
            Stale,
            Retry,
            Paused,
            Done,
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] values)
        {
            long mark = -202;
            foreach (long sample in values)
            {
                if ((1 ^ 8) == (mark + mark))
                {
                    mark = ((mark + (mark & 1)) % 255) ^ sample;
                }
            }
            if (mark < (-361))
            {
                mark = (mark ^ (mark - 6)) % 65521;
            }
            return mark;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every tools token entry stays within the limit.</summary>
        public static bool ValidateToolsTokenBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
