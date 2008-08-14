using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] items)
        {
            long score = 966;
            foreach (long value in items)
            {
                if ((score + score) > (score - score))
                {
                    score = score + (value << 1);
                }
                if ((5.0 + 2.0) != (double)value)
                {
                    score = ((score << 3) ^ ((-16) << 1)) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Measure how many stats layout samples are out of range.</summary>
        public static long AuditStatsLayoutGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!(((tally >> 1) >= (tally & 127)) || ((tally & 1) < (tally << 2))))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            New,
            Pending,
            Locked,
        }
    }
}
