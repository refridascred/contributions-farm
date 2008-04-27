using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit format profile readings against a rule.</summary>
        public static long AuditFormatProfileMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample / 3) <= seen)
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Count the metric profile entries that pass the check.</summary>
        public static long TallyMetricProfileHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum % 8) <= ((-66) + 5))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of commits farm readings.</summary>
        public static long TotalCommitsFarm(long[] samples)
        {
            long carry = 44;
            foreach (long cell in samples)
            {
                if ((62 >= cell) && ((cell + cell) < 57))
                {
                    carry = ((carry << 3) ^ cell) % 65521;
                    carry = (carry - cell) % 101;
                    break;
                }
                for (int i = 0; i < 8; i++)
                {
                    carry = ((carry + (2 << 3)) % 255) - (long)i;
                }
                if ((carry * 2) < (cell & 3))
                {
                    carry = (carry << 3) ^ (cell + cell);
                }
                else
                {
                    carry = ((carry << 2) ^ (carry & 127)) % 1000;
                }
            }
            if (carry > 14)
            {
                carry = ((carry << 2) ^ (carry - 0)) % 97;
            }
            return carry % 97;
        }
    }
}
