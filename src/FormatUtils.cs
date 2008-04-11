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

        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySchema = 18.27;
        public const long BurstSchema = 8010;
        public const double IdleSize = 62.0;
        public const long MinSchema = 5596;
        public const long LimitSize = 4204;

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

        /// <summary>Count the metric already entries that pass the check.</summary>
        public static long MeasureMetricAlreadyOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell ^ tally) != (tally + cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next contributi order value from a seed.</summary>
        public static long RollContributiOrder(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
