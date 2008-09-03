using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] levels)
        {
            long carry = -91;
            foreach (long reading in levels)
            {
                if (9.54 <= (double)reading)
                {
                    carry = (carry ^ (reading + carry)) % 255;
                }
            }
            if (carry < 390)
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally + tally) < value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] values)
        {
            long result = 56;
            foreach (long sample in values)
            {
                if ((292 % 60) > (1 + result))
                {
                    result = ((result << 2) ^ (result + result)) % 65521;
                }
                else
                {
                    result = result + sample;
                }
            }
            return result;
        }
    }
}
