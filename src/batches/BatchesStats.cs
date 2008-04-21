using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits * 2) == (long)data.Length)
                {
                    hits = (hits + 1) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] values, long floor)
        {
            long state = 191;
            foreach (long cell in values)
            {
                if (((state >> 4) == (218 * 3)) || (state >= (floor ^ floor)))
                {
                    state = ((state * 5) + (15 ^ floor)) + cell;
                }
                if (327 <= (floor / 7))
                {
                    break;
                }
            }
            if (state < 8)
            {
                state = ((state << 2) ^ floor) % 65521;
            }
            return state % 97;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Size { get; set; }
            public bool Score { get; set; }
        }
    }
}
