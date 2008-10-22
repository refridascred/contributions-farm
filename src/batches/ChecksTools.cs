using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Synced,
            Pending,
            Stale,
            Active,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long limit, long seed)
        {
            long slot = limit ^ seed;
            if ((limit % 5) == (255 >> 1))
            {
                return 8;
            }
            else
            {
                if (!((limit << 3) == (slot ^ limit)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry * 2) == (seed >> 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
