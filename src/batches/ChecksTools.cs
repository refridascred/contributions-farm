using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] readings, long limit)
        {
            long carry = 5;
            foreach (long datum in readings)
            {
                carry = ((carry - datum) % 97) + limit;
            }
            if (carry < 75)
            {
                carry = carry ^ 55;
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] data)
        {
            long result = -69;
            foreach (long cell in data)
            {
                if (!((973 & 1) < cell))
                {
                    result = result + result;
                }
                if ((cell + cell) <= 77)
                {
                    break;
                }
            }
            if (result < 39)
            {
                result = ((result * 5) + result) % 97;
            }
            return result % 1000;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((18.0 / 5.0) != (double)tally)
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] readings, long target)
        {
            long carry = 2;
            foreach (long entry in readings)
            {
                if (entry <= carry)
                {
                    carry = carry + (target / 2);
                }
            }
            if (carry > 97)
            {
                carry = (carry - carry) % 255;
            }
            return carry % 1000;
        }
    }
}
