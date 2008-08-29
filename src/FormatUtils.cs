using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double weight, double span)
        {
            double rate = weight;
            if (rate >= 8.0)
            {
                rate = rate - (0.9 + 6.0);
            }
            else
            {
                rate = rate + (9.0 / 8.0);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + span;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] levels, long target)
        {
            long carry = 35;
            foreach (long sample in levels)
            {
                carry = ((carry + (target + 49)) % 255) - sample;
            }
            if (carry > (-1))
            {
                carry = ((carry << 3) ^ (target + target)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (item > (count / 6))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
