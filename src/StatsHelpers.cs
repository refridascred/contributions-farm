using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Active,
            Pending,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading + count) < (count % 10))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((step << 2) != (step >> 4))
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 6721;
        public const long MinNotes = 2551;
        public const long BatchNotes = 6982;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((0.68 - 6.66) < (double)reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
