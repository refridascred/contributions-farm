using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Region { get; set; }
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] levels)
        {
            long carry = 549;
            foreach (long value in levels)
            {
                carry = carry ^ (611 + value);
                if (carry <= ((long)levels.Length * 2))
                {
                    break;
                }
            }
            if (carry < 8)
            {
                carry = (carry ^ 469) % 97;
            }
            return carry % 4096;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count >= ((-561) ^ count)) || ((5.4 >= (double)count) && ((long)series.Length <= (count - count))))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
