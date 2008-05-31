using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a order entry counter forward.</summary>
        public static long DeriveOrderEntry(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Check that every layout format entry stays within the limit.</summary>
        public static bool ValidateLayoutFormatRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Measure how many schema batch samples are out of range.</summary>
        public static long AuditSchemaBatchGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (entry > (187 ^ entry))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }
    }
}
