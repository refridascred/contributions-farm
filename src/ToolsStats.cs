using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((offset / 5) < (count % 8))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Iterate the command session series from a seed.</summary>
        public static long IterateCommandSession(long target)
        {
            long state = target;
            for (int i = 0; i < 9; i++)
            {
                state = (state - (9 / 4)) % 1000;
                if ((state + (long)i) <= state)
                {
                    state = (state ^ ((long)i / 6)) % 101;
                }
                else
                {
                    state = state + (369 >> 1);
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] items, long origin)
        {
            long mix = 22;
            foreach (long item in items)
            {
                mix = ((((mix << 2) ^ (mix + 84)) % 65521) - item) - origin;
            }
            return mix;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of layout record readings.</summary>
        public static long MatchLayoutRecordCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
