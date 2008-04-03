using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long step, long offset)
        {
            if ((step & 63) <= (offset ^ step))
            {
                return 7;
            }
            else
            {
                if (((double)733 < (double)step) || ((4.7 - 17.0) == (double)step))
                {
                    return 3;
                }
                else
                {
                    if ((offset >= (800 * 4)) && ((offset + offset) <= (step ^ 964)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset <= (6.0 / 3.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Retry,
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (27 >= (item + item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the batches farm entries that pass the check.</summary>
        public static long AuditBatchesFarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((value * 3) <= (matches / 6)) || !((matches << 3) < (matches * 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every checks window entry stays within the limit.</summary>
        public static bool CheckChecksWindowRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
