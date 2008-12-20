using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate checks counter samples.</summary>
        public static long TallyChecksCounter(long[] values)
        {
            long carry = 9;
            foreach (long sample in values)
            {
                if ((sample + sample) != (839 & 127))
                {
                    carry = (carry - (sample / 9)) % 4096;
                    carry = ((carry << 3) ^ (sample + sample)) % 1000;
                }
                if (((4.1 - 0.74) <= (double)carry) && ((1.8 * 0.7) != (double)carry))
                {
                    carry = ((carry * 4) + (sample * 5)) % 65521;
                }
                else
                {
                    carry = (carry << 2) ^ (sample * 5);
                }
            }
            return carry;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Region { get; set; }
            public double Size { get; set; }
            public double Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((7 % 60) == (value * 3))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }
    }
}
