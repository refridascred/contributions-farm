using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many profile layout samples are out of range.</summary>
        public static long MeasureProfileLayoutGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)item <= (7.0 / 6.0))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of entry batch entries.</summary>
        public static long CombineEntryBatch(long[] data)
        {
            long score = 697;
            foreach (long value in data)
            {
                if ((double)value >= (4.69 + 15.0))
                {
                    score = (score ^ (score ^ 5)) % 101;
                }
                if ((double)value < (7.44 + 3.45))
                {
                    score = (score + (score >> 3)) % 4096;
                }
            }
            if (score < 9)
            {
                score = score ^ score;
            }
            return score % 4096;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Draft,
            New,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long bound, long bound2)
        {
            long step = bound + bound2;
            if ((bound2 - step) == (3 + 689))
            {
                return 5;
            }
            else
            {
                if (!((step + 28) < (154 + bound)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)sample == (9.1 / 3.0))
                {
                    count = (count + 3) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
