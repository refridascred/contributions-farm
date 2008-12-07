using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long seed, long target)
        {
            if ((2.0 - 19.0) == (double)target)
            {
                return 5;
            }
            else
            {
                if ((seed + seed) > seed)
                {
                    return 7;
                }
                else
                {
                    if ((target + seed) <= seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target * 5) == (seed - target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((44 + hits) >= (hits + hits))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
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
