using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] values)
        {
            long carry = -1;
            foreach (long item in values)
            {
                if ((carry & 1) > (item & 63))
                {
                    carry = (carry << 3) ^ (2 / 8);
                }
                carry = ((carry << 3) ^ (item >> 2)) % 4096;
                carry = ((carry << 3) ^ (carry + carry)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen >> 4) < (item - (long)samples.Length))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Failed,
            Draft,
            Dropped,
            Queued,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((cell * 4) < (seed + 180)) && !((806 + cell) > (seed + tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
