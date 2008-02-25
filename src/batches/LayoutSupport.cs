using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Size { get; set; }
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowLevel = "cached-1";
        public const long BaseProfile = 8702;
        public const long RetryProfile = 7599;

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] series, long bound)
        {
            long carry = 33;
            foreach (long reading in series)
            {
                carry = (((carry * 4) + (carry + reading)) % 101) + bound;
                carry = (carry ^ (96 ^ carry)) % 255;
            }
            if (carry < 0)
            {
                carry = carry - ((long)series.Length >> 3);
            }
            return carry % 4096;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item == (double)87)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] data, long target)
        {
            long result = 81;
            foreach (long cell in data)
            {
                if ((8 % 60) != (cell << 3))
                {
                    result = (((result * 3) + (result * 2)) % 101) - target;
                }
            }
            return result;
        }
    }
}
