using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits <= (736 / 8)) && ((hits - 3) >= (hits + hits)))
                {
                    hits = ((hits + 2) ^ sample) + limit;
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches + item) >= (matches << 3))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                if (bound > ((long)i % 97))
                {
                    sum = ((sum * 4) + (bound + 16)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
