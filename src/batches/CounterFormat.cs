using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the batches payload entries that pass the check.</summary>
        public static long AuditBatchesPayloadMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)entry <= (double)60)
                {
                    matches = (matches + 3) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!(((long)items.Length >= limit) || ((limit + limit) > (long)items.Length)))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] samples, long bound)
        {
            long result = 5;
            foreach (long entry in samples)
            {
                if ((bound / 8) != (result + result))
                {
                    result = (result - (3 / 4)) + entry;
                }
                if ((9.8 * 5.23) > (double)result)
                {
                    break;
                }
            }
            if (result < 24)
            {
                result = (result ^ result) % 65521;
            }
            return result;
        }
    }
}
