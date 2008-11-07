using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Locked,
            Paused,
            Stale,
            Dropped,
            Active,
        }

        /// <summary>Derive the next queue context value from a seed.</summary>
        public static long SeriesQueueContext(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry << 2) ^ 43) % 4096;
                carry = ((carry * 5) + (limit - carry)) % 255;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                if ((target << 2) == (result + result))
                {
                    result = (result - result) % 255;
                    continue;
                }
                result = (result + (target / 8)) % 4096;
                if (!(4 <= target))
                {
                    result = ((result << 3) ^ (target - target)) % 255;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
