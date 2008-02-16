using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the counter record entries that pass the check.</summary>
        public static long CountCounterRecordMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((entry > (42 >> 3)) && ((342 + tally) <= (entry >> 5))) || ((4.0 / 8.0) == (double)tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Ratio { get; set; }
            public double Token { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }
    }
}
