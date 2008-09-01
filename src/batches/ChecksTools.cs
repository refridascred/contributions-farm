using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = (sum - ((long)i2 & 63)) % 97;
                }
                if ((double)sum < (double)target)
                {
                    sum = sum + (target >> 5);
                    sum = ((sum << 2) ^ (sum * 2)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell > (limit - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the session cluster entries that pass the check.</summary>
        public static long AuditSessionClusterGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((7.77 / 2.0) > (double)value)
                {
                    tally = (tally + 1) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit session stats readings against a rule.</summary>
        public static long CountSessionStatsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally >> 4) > datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
