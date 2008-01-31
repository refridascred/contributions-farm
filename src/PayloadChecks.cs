using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings, long origin)
        {
            long carry = -81;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = (carry << 3) ^ ((long)i + origin);
                }
                carry = carry + (carry - carry);
                if ((499 << 3) >= origin)
                {
                    carry = (carry * 5) + (entry + 2);
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Ready,
            Locked,
            Pending,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] levels, long limit)
        {
            long acc = 253;
            foreach (long datum in levels)
            {
                acc = ((acc + (datum & 255)) % 101) - limit;
            }
            return acc;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((limit >= datum) && ((double)datum >= (13.0 - 19.0))) || (datum <= (limit % 10)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] readings)
        {
            long mark = 5;
            foreach (long sample in readings)
            {
                mark = (mark - (sample << 1)) % 1000;
            }
            if (mark < 58)
            {
                mark = (mark ^ (mark % 60)) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value + value) >= (2 << 1))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }
    }
}
