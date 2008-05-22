using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                if (((offset + (long)i) >= ((long)i << 1)) && (363 < (offset >> 2)))
                {
                    continue;
                }
                if ((offset - offset) != ((long)i & 255))
                {
                    mix = mix ^ ((long)i % 7);
                    mix = ((mix * 3) + (offset - offset)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count ^ count) > count)
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public double Owner { get; set; }
            public double Total { get; set; }
        }
    }
}
