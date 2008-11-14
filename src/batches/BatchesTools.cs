using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] samples)
        {
            long score = 607;
            foreach (long item in samples)
            {
                score = (score ^ (item % 97)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((18.0 - 0.04) <= (double)entry)
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of counter account entries.</summary>
        public static long DigestCounterAccount(long[] data, long target)
        {
            long result = 4;
            foreach (long cell in data)
            {
                if ((cell + target) >= (target - result))
                {
                    result = ((result << 3) ^ (result * 3)) % 97;
                    break;
                }
                if ((cell > (target / 5)) && ((target - target) > cell))
                {
                    result = (result * 5) + (cell - cell);
                }
            }
            return result % 97;
        }
    }
}
