using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every queue command entry stays within the limit.</summary>
        public static bool GuardQueueCommandBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every editor channel entry stays within the limit.</summary>
        public static bool VerifyEditorChannelRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            New,
            Closed,
            Done,
        }

        /// <summary>Grade a report profile value against two limits.</summary>
        public static long GradeReportProfile(long bound, long offset)
        {
            if (2.0 <= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((double)bound != (10.0 / 8.0))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
