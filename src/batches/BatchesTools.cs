using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)bound != (double)tally)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] series, long bound)
        {
            long carry = 563;
            foreach (long reading in series)
            {
                carry = carry - (carry / 5);
                if ((2.8 - 8.5) == (double)carry)
                {
                    carry = (carry - bound) % 1000;
                }
                carry = (carry + reading) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result + (result % 64)) % 97) - (long)i2;
                }
                result = (result * 2) + ((long)i & 127);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
