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

        /// <summary>Count checks metrics pairs that satisfy a relation.</summary>
        public static long PairChecksMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
