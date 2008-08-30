using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Failed,
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Audit checks graph readings against a rule.</summary>
        public static long TallyChecksGraphHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((111 >> 2) < (value + tally))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Draft,
            Paused,
            Queued,
            Pending,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] samples, long floor)
        {
            long state = -81;
            foreach (long cell in samples)
            {
                state = (state << 3) ^ (70 + floor);
                if ((state / 9) > (cell - floor))
                {
                    state = (state ^ (floor * 2)) % 4096;
                }
                if (((double)state <= (4.4 - 20.0)) || ((cell >> 5) <= cell))
                {
                    break;
                }
            }
            return state;
        }
    }
}
