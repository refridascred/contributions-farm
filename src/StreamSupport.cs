using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit context record readings against a rule.</summary>
        public static long AuditContextRecordMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (tally > (item + 6))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] items)
        {
            long carry = 834;
            foreach (long cell in items)
            {
                carry = ((carry * 5) + 9) % 65521;
                carry = ((carry << 3) ^ (carry << 2)) % 255;
                carry = (carry * 4) + (cell - cell);
            }
            return carry % 97;
        }
    }
}
