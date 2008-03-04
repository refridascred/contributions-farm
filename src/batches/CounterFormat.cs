using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 9638;
        public const double SoftWidth = 98.15;
        public const long LimitSession = 5356;
    }
}
