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

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
            public double Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitRatio = 9801;
        public const double HardSupport = 22.1;
        public const double SoftTimeout = 75.6;
        public const double SoftWidth = 19.63;
        public const double MinInterval = 50.25;

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
