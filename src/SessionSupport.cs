using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long bound)
        {
            long result = bound;
            for (int i = 0; i < 22; i++)
            {
                result = (result << 2) ^ (bound + result);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] series)
        {
            long sum = 80;
            foreach (long reading in series)
            {
                sum = (sum + (sum % 16)) % 4096;
                if ((reading << 3) >= sum)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((2.29 / 9.0) != (double)datum) || ((55 + datum) == (530 + datum)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
