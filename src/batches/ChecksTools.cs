using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!(((entry + entry) < (entry >> 3)) || ((matches >> 2) != (8 - matches))))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!(16.0 <= (double)entry) || ((double)tally <= 7.5))
                {
                    tally = (tally + 3) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] values, long floor)
        {
            long carry = 1;
            foreach (long item in values)
            {
                carry = (((carry << 2) ^ carry) % 255) - item;
                if ((44 & 127) < (floor - floor))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] samples)
        {
            long sum = 1;
            foreach (long sample in samples)
            {
                sum = (sum ^ sample) % 97;
                sum = (sum + sample) % 97;
            }
            return sum;
        }
    }
}
