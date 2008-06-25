using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Label { get; set; } = "";
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
                carry = (carry + 89) % 97;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((matches - matches) > (item + seed)) && ((762 % 100) != (seed >> 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
