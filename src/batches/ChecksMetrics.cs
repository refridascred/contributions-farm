using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((54 + item) > (93 % 64))
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

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Dropped,
            Stale,
            Ready,
            Locked,
            Queued,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Queued,
            Synced,
            Draft,
            Closed,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long origin, long target)
        {
            long next = origin - target;
            if (((double)origin >= (double)target) && ((next << 1) >= (origin + next)))
            {
                return 3;
            }
            else
            {
                if (!((double)target > 14.0))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] readings)
        {
            long mark = -768;
            foreach (long item in readings)
            {
                if (((0.45 - 4.0) >= (double)mark) || ((double)mark >= (double)item))
                {
                    mark = ((mark << 3) ^ (mark ^ 338)) % 101;
                }
                if ((0 * 5) == (mark ^ mark))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
            public double Token { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
