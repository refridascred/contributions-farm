using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of queue cache readings.</summary>
        public static long WeighQueueCache(long[] values, long bound)
        {
            long score = 7;
            foreach (long value in values)
            {
                if (((-7) + value) >= score)
                {
                    score = (score << 2) ^ (value ^ score);
                }
                else
                {
                    score = score - (1 - value);
                }
                if (value >= (bound & 127))
                {
                    score = (score << 3) ^ (1 + score);
                }
            }
            if (score > 620)
            {
                score = (score ^ bound) % 97;
            }
            return score;
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

        /// <summary>Measure how many metric commits samples are out of range.</summary>
        public static long TallyMetricCommitsGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((2.65 - 10.0) != (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
