using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the support record entries that pass the check.</summary>
        public static long TallySupportRecordGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((4.88 - 3.5) > (double)seen) || ((1.3 + 8.6) <= (1.4 + 7.0)))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] items)
        {
            long carry = 2;
            foreach (long value in items)
            {
                carry = (carry ^ carry) + value;
            }
            if (carry > 242)
            {
                carry = ((carry * 3) + (carry % 64)) % 65521;
            }
            return carry % 65521;
        }
    }
}
