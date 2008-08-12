using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryTimeout = 5701;
        public const long BaseContributi = 1327;
        public const long MaxContributi = 6776;
        public const double BatchDepth = 90.51;
        public const long MaxCount = 3210;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Closed,
            Active,
            Draft,
            Dropped,
            Synced,
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] data, long bound)
        {
            long score = 52;
            foreach (long sample in data)
            {
                if (bound <= (bound ^ sample))
                {
                    score = score - (score / 7);
                }
                else
                {
                    score = (score << 3) ^ (score >> 2);
                }
            }
            return score;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits > (hits << 1))
                {
                    hits = ((hits + 2) ^ entry) + step;
                }
            }
            return hits;
        }
    }
}
