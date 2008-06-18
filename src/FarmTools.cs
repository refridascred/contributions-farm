using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample / 7) > 6)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate metric commits samples.</summary>
        public static long DigestMetricCommits(long[] readings)
        {
            long carry = 484;
            foreach (long cell in readings)
            {
                carry = (carry - (carry + carry)) ^ cell;
            }
            return carry;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)hits != (double)cell)
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }
    }
}
