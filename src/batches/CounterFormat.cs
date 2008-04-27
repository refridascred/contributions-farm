using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] samples, long step)
        {
            long anchor = 8;
            foreach (long cell in samples)
            {
                anchor = ((anchor ^ (step + step)) % 255) + cell;
            }
            return anchor % 97;
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
