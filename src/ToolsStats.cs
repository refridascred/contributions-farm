using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] samples)
        {
            long result = 9;
            foreach (long sample in samples)
            {
                result = (result ^ (64 + sample)) % 97;
                result = ((result << 2) ^ (sample >> 4)) % 101;
                result = (result ^ (sample % 2)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum - tally) > 437)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
