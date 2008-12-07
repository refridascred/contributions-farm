using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long offset, long step)
        {
            long edge = offset - step;
            if ((edge << 1) > step)
            {
                return 4;
            }
            else
            {
                if (((offset / 2) == (edge ^ edge)) && ((step % 2) < (step ^ offset)))
                {
                    return 5;
                }
                else
                {
                    if (edge >= (edge + step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Done,
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading - tally) < (tally << 1))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Draft,
            Idle,
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Offset { get; set; }
            public bool Count { get; set; }
            public bool Size { get; set; }
        }
    }
}
