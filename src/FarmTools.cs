using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the account channel entries that pass the check.</summary>
        public static long TallyAccountChannelGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((-442) * 3) >= (matches * 3))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Flag { get; set; }
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitDepth = 8685;
        public const long BaseWidth = 5938;
        public const long BatchLayout = 3185;
        public const double IdleLayout = 2.23;
    }
}
