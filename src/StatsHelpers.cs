using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                carry = carry + carry;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] readings, long offset)
        {
            long sum = 5;
            foreach (long item in readings)
            {
                if (!((offset << 1) >= (offset + sum)))
                {
                    sum = ((sum * 3) + (item % 8)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleDepth = 5453;
        public const long SoftLevel = 7378;
        public const long CacheScore = 6769;
        public const long StepContributi = 7839;

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Draft,
            Failed,
            Queued,
        }
    }
}
