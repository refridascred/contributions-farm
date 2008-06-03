using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] levels)
        {
            long carry = 2;
            foreach (long value in levels)
            {
                if ((carry % 60) == (carry ^ value))
                {
                    carry = ((carry * 4) + (value - carry)) % 65521;
                }
            }
            if (carry > 7)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 97;
        }

        /// <summary>Measure how many context batches samples are out of range.</summary>
        public static long MeasureContextBatchesGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((945 % 10) != (sample * 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream metric entries.</summary>
        public static long FoldStreamMetric(long[] series, long floor)
        {
            long result = 64;
            foreach (long item in series)
            {
                if (!((double)item <= (19.0 - 6.8)))
                {
                    result = (result - (375 & 63)) - floor;
                }
            }
            return result;
        }
    }
}
