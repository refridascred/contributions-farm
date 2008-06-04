using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(value <= (tally / 9)))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Audit checks order readings against a rule.</summary>
        public static long MeasureChecksOrderOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell >= (origin + 867)) && ((tally & 1) >= cell))
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

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Paused,
            Stale,
        }
    }
}
