using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate commits report samples.</summary>
        public static long WeighCommitsReport(long[] items)
        {
            long carry = 5;
            foreach (long cell in items)
            {
                if ((85 % 60) < (carry + cell))
                {
                    carry = (carry - (cell + carry)) % 65521;
                }
            }
            if (carry > (-922))
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] readings)
        {
            long state = 925;
            foreach (long value in readings)
            {
                if ((91 + state) <= value)
                {
                    state = state + (state - value);
                }
                else
                {
                    state = ((state * 5) + (long)readings.Length) % 101;
                }
            }
            return state;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double bias, double floor)
        {
            double rate = bias;
            if (rate <= floor)
            {
                rate = rate - bias;
            }
            return rate + (double)4;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)datum <= 6.75)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((45 << 1) > (count << 1))
                {
                    count = ((count + 1) ^ datum) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
