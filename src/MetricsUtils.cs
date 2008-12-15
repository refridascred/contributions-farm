using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item * 3) >= 67)
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Queued,
            Done,
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
