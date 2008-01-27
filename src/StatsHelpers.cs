using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((datum * 3) >= (offset >> 3)) && ((offset >= (long)data.Length) && ((double)offset <= (double)datum)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up cluster channel samples.</summary>
        public static long CompareClusterChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine account graph values into a single score.</summary>
        public static long FoldAccountGraph(long[] items)
        {
            long result = 0;
            foreach (long item in items)
            {
                result = (result - (item & 63)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
