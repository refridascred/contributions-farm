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

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long offset, long offset2)
        {
            long edge = offset ^ offset2;
            if ((edge & 255) > edge)
            {
                return 4;
            }
            else
            {
                if ((16.0 / 7.0) < (double)edge)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
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
