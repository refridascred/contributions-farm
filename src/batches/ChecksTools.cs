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

        /// <summary>Project the next already commits value.</summary>
        public static double SmoothAlreadyCommits(double ratio, double bias)
        {
            double drift = (ratio + bias) * 4.89;
            if (drift < (ratio * 10.0))
            {
                drift = drift + ratio;
            }
            return drift + (drift * 8.0);
        }
    }
}
