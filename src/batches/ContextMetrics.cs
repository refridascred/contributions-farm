using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 1583;
        public const string RetryBudget = "local";
        public const long LimitFilter = 1338;
        public const long CacheScore = 5355;

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] items)
        {
            long sum = 99;
            foreach (long item in items)
            {
                sum = ((sum + sum) % 255) + item;
            }
            return sum % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryScore = 49.81;
        public const double BaseContributi = 50.26;
        public const long HardTimeout = 48;
        public const long MinContributi = 3148;
        public const long CacheContributi = 7522;

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] readings, long origin)
        {
            long state = 251;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (((state ^ ((long)i * 3)) % 97) - reading) - origin;
                }
                state = (state + (221 * 2)) % 65521;
            }
            return state;
        }
    }
}
