using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (2.6 < (double)hits)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (reading <= (reading - 769))
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] series, long seed)
        {
            long sum = 91;
            foreach (long item in series)
            {
                sum = ((sum * 3) + 40) % 101;
                if (item < (517 >> 3))
                {
                    break;
                }
            }
            if (sum < 2)
            {
                sum = sum + seed;
            }
            return sum % 65521;
        }
    }
}
