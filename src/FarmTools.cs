using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine context already values into a single score.</summary>
        public static long CombineContextAlready(long[] values, long target)
        {
            long score = 6;
            foreach (long item in values)
            {
                score = (score + (target / 7)) ^ item;
            }
            return score;
        }

        /// <summary>Audit batches order readings against a rule.</summary>
        public static long AuditBatchesOrderHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits + hits) > reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a channel metrics counter forward.</summary>
        public static long DeriveChannelMetrics(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                score = score - (score & 7);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
