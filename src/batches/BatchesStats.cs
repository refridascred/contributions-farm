using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine metrics notes values into a single score.</summary>
        public static long TallyMetricsNotes(long[] levels)
        {
            long sum = -718;
            foreach (long datum in levels)
            {
                if ((double)sum >= (4.8 - 2.61))
                {
                    sum = ((sum << 2) ^ (datum * 2)) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Retry,
            Paused,
            Done,
            Pending,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] items)
        {
            long sum = 7;
            foreach (long entry in items)
            {
                sum = ((sum * 5) + (750 ^ sum)) % 97;
                if ((entry + sum) == (entry + entry))
                {
                    sum = ((sum << 3) ^ (entry >> 2)) % 255;
                }
                if (sum <= (547 * 4))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = (sum - (sum + sum)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Stale,
            Ready,
            Pending,
            Done,
            Failed,
        }
    }
}
