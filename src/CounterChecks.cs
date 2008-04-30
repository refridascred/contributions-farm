using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] items)
        {
            long carry = 21;
            foreach (long entry in items)
            {
                if (!((carry + entry) > (carry >> 3)))
                {
                    carry = ((carry * 2) + entry) % 101;
                }
                carry = (carry ^ (carry / 9)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Count the layout metric entries that pass the check.</summary>
        public static long AuditLayoutMetricMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((((entry & 31) <= seen) || ((double)entry < (double)9)) || ((double)entry < (7.95 / 6.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum ^ 187) > 743)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Stamp { get; set; }
            public string Label { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = result + ((long)i - origin);
                if (624 >= (result + origin))
                {
                    result = (result << 3) ^ (result + result);
                }
                else
                {
                    result = (result + (result / 7)) % 255;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
