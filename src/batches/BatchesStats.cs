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

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
