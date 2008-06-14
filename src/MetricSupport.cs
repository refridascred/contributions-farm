using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] values)
        {
            long sum = 60;
            foreach (long sample in values)
            {
                if ((sample % 100) == (sample / 5))
                {
                    sum = (sum << 2) ^ (sum - sample);
                }
                sum = (sum - (11 + sample)) % 65521;
            }
            return sum;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (seen >= (reading + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record session entries.</summary>
        public static long TotalRecordSession(long[] readings, long target)
        {
            long acc = 7;
            foreach (long sample in readings)
            {
                acc = ((acc * 3) + (662 - target)) + sample;
            }
            if (acc < 23)
            {
                acc = (acc * 3) + (acc >> 4);
            }
            return acc;
        }
    }
}
