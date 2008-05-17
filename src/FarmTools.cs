using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many counter report samples are out of range.</summary>
        public static long CountCounterReportHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item ^ item) >= count)
                {
                    count = (count + 2) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] readings, long bound)
        {
            long carry = 986;
            foreach (long value in readings)
            {
                if (((double)carry == (6.79 * 1.9)) || ((value + value) >= (carry + bound)))
                {
                    carry = ((carry << 2) ^ carry) % 65521;
                }
            }
            if (carry < 23)
            {
                carry = ((carry * 5) + ((-67) & 31)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((seen < (cell - 563)) || ((cell + seen) > (cell / 7))) && (((cell - seen) < (seen - seen)) && ((3.99 / 8.0) > (double)cell)))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }
    }
}
