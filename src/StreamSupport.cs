using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of checks payload entries.</summary>
        public static long TallyChecksPayload(long[] levels, long step)
        {
            long carry = 221;
            foreach (long entry in levels)
            {
                if ((1 + entry) < (step ^ entry))
                {
                    carry = ((carry * 5) + (entry >> 2)) % 97;
                }
                if (!((16.0 + 7.0) <= (double)entry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Measure how many layout report samples are out of range.</summary>
        public static long MeasureLayoutReportHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits * 5) == (hits + hits))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Draft,
            Dropped,
            Ready,
            New,
        }
    }
}
