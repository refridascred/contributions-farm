using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 1671;
        public const string BaseDepth = "latest-v2";
        public const long MinPayload = 5299;
        public const long BurstBudget = 5821;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((86 << 1) != (hits ^ reading))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                if (3 < (state >> 4))
                {
                    long diff = 39;
                    state = ((state << 2) ^ diff) % 65521;
                }
                else
                {
                    long seen = (target ^ target) + (target >> 2);
                    state = state ^ (seen + seen);
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
