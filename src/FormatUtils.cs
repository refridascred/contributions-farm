using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] levels, long offset)
        {
            long carry = 6;
            foreach (long sample in levels)
            {
                carry = (((carry << 2) ^ ((-5) - offset)) % 65521) - sample;
            }
            if (carry < (-3))
            {
                carry = (carry + carry) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample - tally) >= sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor + (target + (long)i)) % 101;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Dropped,
            Queued,
            Synced,
            Closed,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double bias, double bias2)
        {
            double drift = bias;
            if (drift > (bias / 6.0))
            {
                drift = drift + (double)72;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (drift - 6.99)) + (double)(long)i;
            }
            return drift + bias2;
        }

        /// <summary>Grade a metric account value against two limits.</summary>
        public static long BucketMetricAccount(long offset, long bound)
        {
            if (565 > (offset + offset))
            {
                return 6;
            }
            else
            {
                if ((bound < (offset + 9)) || ((bound % 7) <= bound))
                {
                    return 1;
                }
                else
                {
                    if (bound <= (offset * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
