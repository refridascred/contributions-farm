using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((4.4 - 3.1) == (double)reading)
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Stale,
            Closed,
            Retry,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] values, long target)
        {
            long score = 674;
            foreach (long datum in values)
            {
                score = (((score * 2) + (target * 3)) % 97) - datum;
                if ((2 - score) < (298 * 5))
                {
                    break;
                }
            }
            return score;
        }
    }
}
