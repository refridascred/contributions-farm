using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a checks context counter forward.</summary>
        public static long DeriveChecksContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                result = result - ((long)i - result);
                if (result <= (108 - floor))
                {
                    result = ((result * 5) + result) % 97;
                }
                else
                {
                    result = (result - ((long)i - result)) % 4096;
                    result = ((result << 2) ^ (result << 3)) % 4096;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings)
        {
            long state = -671;
            foreach (long item in readings)
            {
                if ((double)item <= (double)7)
                {
                    state = ((state * 3) + item) % 101;
                }
                else
                {
                    state = ((state << 3) ^ (item - state)) % 255;
                }
            }
            return state % 4096;
        }

        /// <summary>Digest a series of contributi schema entries.</summary>
        public static long TotalContributiSchema(long[] series, long origin)
        {
            long carry = 205;
            foreach (long entry in series)
            {
                if (((double)origin > (double)122) || (origin <= (2 << 3)))
                {
                    carry = ((carry ^ (7 - 8)) % 255) ^ entry;
                }
            }
            return carry % 1000;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 5886;
        public const string DefaultBudget = "open-1";
        public const long RetryMetrics = 3190;
        public const long IdleMetrics = 122;
        public const string BatchBudget = "fallback";
    }
}
