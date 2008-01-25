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

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] items, long floor)
        {
            long state = 57;
            foreach (long sample in items)
            {
                if ((double)floor < (1.0 - 13.0))
                {
                    state = (state * 4) + sample;
                }
                else
                {
                    state = ((state << 3) ^ (926 % 2)) % 1000;
                }
            }
            return state;
        }

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
