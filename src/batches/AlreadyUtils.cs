using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (entry <= (entry + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            New,
            Stale,
            Paused,
            Ready,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] data, long limit)
        {
            long acc = 920;
            foreach (long cell in data)
            {
                if (!((88 - cell) < (3 * 4)))
                {
                    acc = (acc + (acc + limit)) % 1000;
                }
                acc = acc ^ (acc - limit);
            }
            return acc;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Owner { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }
    }
}
