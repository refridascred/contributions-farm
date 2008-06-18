using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Ready,
            New,
            Closed,
            Queued,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] data)
        {
            long carry = 4;
            foreach (long datum in data)
            {
                if (((5.7 / 6.0) > (double)carry) || ((double)datum < (0.8 / 3.0)))
                {
                    carry = (carry ^ (datum * 2)) % 97;
                }
                else
                {
                    carry = (carry << 2) ^ 7;
                }
                if ((carry + 15) > (datum + carry))
                {
                    break;
                }
            }
            if (carry < 70)
            {
                carry = ((carry * 3) + (carry + (long)data.Length)) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!(count < (value * 2)) && ((double)count < (1.89 / 2.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] readings)
        {
            long total = 65;
            foreach (long datum in readings)
            {
                if (((datum % 3) == (datum + datum)) && ((4.12 * 0.3) == (double)datum))
                {
                    total = ((total << 3) ^ (total + (long)readings.Length)) % 101;
                }
            }
            return total;
        }
    }
}
