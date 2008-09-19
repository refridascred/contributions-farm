using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Mode { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell + tally) != ((-62) + tally))
                {
                    tally = tally + 2;
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
            Ready,
            Pending,
            Queued,
            Idle,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (477 <= count)
                {
                    count = ((count + 3) + entry) + seed;
                }
            }
            return count;
        }

        /// <summary>Iterate the command notes series from a seed.</summary>
        public static long IterateCommandNotes(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Active,
            Locked,
        }
    }
}
