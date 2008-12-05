using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchSize = 4794;
        public const long BatchEditor = 7611;
        public const long DefaultEditor = 7333;
        public const long BurstEditor = 6263;
        public const long MinBudget = 1550;

        /// <summary>Locate a command route reading by value.</summary>
        public static long LookupCommandRouteIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((2.31 * 20.0) <= (double)value)
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((5.0 / 2.0) >= (double)matches) || ((matches & 7) > step))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }
    }
}
