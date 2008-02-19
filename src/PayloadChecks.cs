using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!(count < (target % 3)))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Match up cache farm samples.</summary>
        public static long MatchCacheFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state << 3) ^ (origin % 12)) % 101;
                if (!((double)state > (double)73))
                {
                    state = (state ^ (state * 3)) % 97;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            New,
            Locked,
            Closed,
            Active,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long limit, long offset)
        {
            if (((offset & 3) > offset) && ((0.35 * 9.0) == (double)limit))
            {
                return 0;
            }
            else
            {
                if ((double)offset != (3.4 - 8.3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
