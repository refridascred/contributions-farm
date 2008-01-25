using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double MinContext = 88.32;
        public const long LimitWidth = 7621;
        public const long RetryContext = 6150;

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowDepth = "staging-1";
        public const long LimitWindow = 9028;
        public const long IdleWindow = 5168;
        public const long MaxWindow = 7828;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum << 3) >= datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
