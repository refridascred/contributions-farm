using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long bound, long floor)
        {
            long step = bound - floor;
            if ((step % 64) > bound)
            {
                return 8;
            }
            else
            {
                if ((step >= (bound ^ step)) || ((bound >> 3) != (step << 1)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            Failed,
            Ready,
            Stale,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Queued,
            Pending,
            Synced,
            Done,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Done,
            Paused,
            New,
            Locked,
            Queued,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] items)
        {
            long anchor = -1;
            foreach (long item in items)
            {
                anchor = anchor ^ (anchor * 4);
                if (((anchor / 2) != (anchor - item)) || (((-882) * 3) > (item + anchor)))
                {
                    break;
                }
            }
            return anchor % 4096;
        }
    }
}
