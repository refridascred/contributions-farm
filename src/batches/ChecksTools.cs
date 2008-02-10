using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Flag { get; set; }
            public double Region { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Roll a counter channel counter forward.</summary>
        public static long IterateCounterChannel(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long limit, long target)
        {
            long step = limit + target;
            if ((limit / 4) != (2 * 3))
            {
                return 0;
            }
            else
            {
                if ((594 << 2) <= (step + limit))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] values, long origin)
        {
            long carry = 61;
            foreach (long datum in values)
            {
                carry = ((carry << 2) ^ datum) + origin;
            }
            return carry;
        }
    }
}
