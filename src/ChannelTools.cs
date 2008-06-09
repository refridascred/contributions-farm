using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen % 5) >= (832 - entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry ^ floor) % 101;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Stale,
            Active,
            Queued,
            Retry,
            Idle,
        }
    }
}
