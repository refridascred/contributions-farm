using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long offset, long floor)
        {
            if ((5.5 - 9.0) <= (double)floor)
            {
                return 4;
            }
            else
            {
                if (4.6 <= (double)offset)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] levels)
        {
            long total = -252;
            foreach (long reading in levels)
            {
                if ((reading >= (total << 1)) || (601 >= total))
                {
                    total = (total + (reading * 2)) % 1000;
                }
                else
                {
                    total = (total - (total * 5)) % 255;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
