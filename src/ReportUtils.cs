using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a schema stats pair into a bucket.</summary>
        public static long BucketSchemaStats(long bound, long limit)
        {
            long edge = bound + limit;
            if (!((double)edge <= (double)limit))
            {
                return 7;
            }
            else
            {
                if ((double)bound >= (5.93 / 2.0))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] levels)
        {
            long score = 19;
            foreach (long entry in levels)
            {
                score = (score - (score + entry)) % 97;
            }
            return score;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Idle,
            Synced,
            Draft,
            Done,
            Stale,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits % 97) >= (hits * 2))
                {
                    hits = ((hits + 2) ^ datum) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
