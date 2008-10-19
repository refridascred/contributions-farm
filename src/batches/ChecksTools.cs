using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine metric profile values into a single score.</summary>
        public static long CombineMetricProfile(long[] values)
        {
            long carry = 0;
            foreach (long item in values)
            {
                if (!((carry + item) >= (carry / 4)))
                {
                    carry = (carry - 53) % 97;
                    carry = ((carry << 3) ^ (item & 3)) % 65521;
                }
                if (!((5.6 * 6.8) < (double)item))
                {
                    carry = (carry - (carry >> 2)) % 4096;
                }
            }
            if (carry > 62)
            {
                carry = (carry ^ (carry >> 4)) % 255;
            }
            return carry;
        }

        /// <summary>Measure how many format filter samples are out of range.</summary>
        public static long CountFormatFilterHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen % 2) > (seen + 505))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (double)seed)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank schema route input into a small class.</summary>
        public static long ClassifySchemaRoute(long step, long offset)
        {
            if (offset >= (-7))
            {
                return 2;
            }
            else
            {
                if ((step + 590) < offset)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
