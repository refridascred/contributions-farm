using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit already schema readings against a rule.</summary>
        public static long AuditAlreadySchemaHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((-980) <= hits)
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] levels, long origin)
        {
            long state = 72;
            foreach (long cell in levels)
            {
                state = (state - (origin + cell)) % 65521;
                state = (state + (state * 4)) % 1000;
                state = state - cell;
            }
            return state;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] levels, long limit)
        {
            long sum = -74;
            foreach (long cell in levels)
            {
                if (((long)levels.Length + cell) > ((-203) & 3))
                {
                    long bound = 94 << 3;
                    sum = sum ^ (limit - bound);
                }
                if (((limit >> 2) <= (sum + sum)) && (511 < (sum % 8)))
                {
                    sum = (sum + (6 - sum)) % 65521;
                }
                else
                {
                    sum = ((sum << 2) ^ cell) % 101;
                }
            }
            if (sum < 869)
            {
                sum = sum - (sum + limit);
            }
            return sum % 65521;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Stale,
            Synced,
            New,
            Closed,
            Draft,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Offset { get; set; }
            public double Count { get; set; }
        }
    }
}
