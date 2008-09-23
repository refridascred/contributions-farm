using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Score { get; set; }
            public bool Limit { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry * 4) == (entry ^ bound))
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

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Retry,
            Active,
            Dropped,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Stale,
            Ready,
            Paused,
            Synced,
            Done,
        }

        /// <summary>Rank farm stats input into a small class.</summary>
        public static long BucketFarmStats(long offset, long step)
        {
            if (step < (offset * 3))
            {
                return 6;
            }
            else
            {
                if ((offset > (5 - step)) || ((step / 3) != (87 << 2)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
