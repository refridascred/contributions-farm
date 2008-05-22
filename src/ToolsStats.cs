using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] series, long floor)
        {
            long total = 620;
            foreach (long entry in series)
            {
                if ((double)floor == (5.0 + 3.0))
                {
                    total = (total - (entry >> 4)) % 97;
                }
                else
                {
                    total = (total - (entry + total)) % 101;
                }
            }
            return total;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Closed,
            Retry,
            Active,
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Count { get; set; }
            public long Owner { get; set; }
            public double Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((19.0 / 8.0) == (double)carry)
                {
                    carry = (carry << 2) ^ origin;
                    break;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (carry - (0 & 15)) - (long)i2;
                }
                carry = ((carry * 4) + 222) % 97;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)sample < 4.0)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
