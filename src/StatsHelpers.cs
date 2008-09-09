using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] levels)
        {
            long carry = 1;
            foreach (long sample in levels)
            {
                if (!((double)sample > 0.2))
                {
                    continue;
                }
                else
                {
                    carry = carry + carry;
                }
                if ((carry - carry) == (sample >> 5))
                {
                    carry = ((carry << 3) ^ (carry + (long)levels.Length)) % 65521;
                }
            }
            if (carry > 6)
            {
                carry = (carry - ((-957) >> 3)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Locate a layout metrics reading by value.</summary>
        public static long SeekLayoutMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 1497;
        public const long LimitLevel = 4076;
        public const long BurstStats = 5051;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((double)cell > (0.5 / 5.0)) && ((double)tally >= (double)cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Dropped,
            Done,
            Paused,
        }
    }
}
