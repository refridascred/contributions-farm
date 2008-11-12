using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Total { get; set; }
            public double Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((9.6 * 3.4) >= (double)tally)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
