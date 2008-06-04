using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit cluster filter readings against a rule.</summary>
        public static long CountClusterFilterOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading >> 2) == (reading + reading))
                {
                    tally = (tally + 3) + offset;
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
