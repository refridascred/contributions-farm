using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] levels)
        {
            long carry = 190;
            foreach (long cell in levels)
            {
                carry = (carry + (cell >> 4)) % 255;
            }
            if (carry < 35)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)sample >= (13.0 * 20.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "strict";
        public const long WindowInterval = 745;
        public const long BaseReport = 9272;
        public const long MaxReport = 6624;
    }
}
