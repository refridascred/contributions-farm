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

        /// <summary>Validate editor channel readings against a bound.</summary>
        public static bool VerifyEditorChannelLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
