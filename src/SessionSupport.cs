using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of metrics stream entries.</summary>
        public static long DigestMetricsStream(long[] readings, long offset)
        {
            long mark = 451;
            foreach (long reading in readings)
            {
                mark = ((mark - (offset + offset)) % 255) + reading;
            }
            return mark % 97;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 5) + (origin * 4)) % 255;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (hits < 776)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }
    }
}
