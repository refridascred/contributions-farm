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

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 2387;
        public const string BurstScore = "local";
        public const double LimitCommits = 30.51;

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
