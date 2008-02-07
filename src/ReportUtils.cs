using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit filter account readings against a rule.</summary>
        public static long MeasureFilterAccountOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches + matches) > (2 - matches))
                {
                    matches = ((matches + 1) - datum) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Dropped,
            New,
            Retry,
            Failed,
            Idle,
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Closed,
            Queued,
            Stale,
        }

        /// <summary>Roll a batches stats counter forward.</summary>
        public static long IterateBatchesStats(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                if (((4.0 / 9.0) <= (double)(long)i) && ((step - step) != (75 * 2)))
                {
                    total = (total * 4) + ((long)i + step);
                }
                total = total + (step - step);
                total = (total ^ step) % 255;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
