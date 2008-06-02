using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 4272;
        public const string LimitLevel = "fallback";
        public const long BaseSpan = 3263;

        /// <summary>Audit queue cluster readings against a rule.</summary>
        public static long AuditQueueClusterHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (sample <= ((long)items.Length >> 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values)
        {
            long acc = 76;
            foreach (long sample in values)
            {
                acc = (acc ^ (acc + sample)) % 65521;
            }
            if (acc > 520)
            {
                acc = (acc ^ (acc / 9)) % 65521;
            }
            return acc;
        }
    }
}
