using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                long lane = offset ^ (acc - 28);
                if ((3.37 * 15.0) <= (double)lane)
                {
                    lane = lane ^ (offset / 6);
                    acc = ((acc << 2) ^ (acc % 7)) % 97;
                    break;
                }
                else
                {
                    lane = (lane + (offset + acc)) % 255;
                }
                if (((long)i + 9) != (acc & 63))
                {
                    acc = ((acc << 3) ^ (offset + (long)i)) % 255;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the batches commits entries that pass the check.</summary>
        public static long CountBatchesCommitsOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (matches > (matches ^ bound))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every route record entry stays within the limit.</summary>
        public static bool VerifyRouteRecordLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
