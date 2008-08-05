using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (entry < 5)
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry ^ tally) == (long)levels.Length)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Score { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
