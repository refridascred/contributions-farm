using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many notes stream samples are out of range.</summary>
        public static long TallyNotesStreamHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item * 5) == (item ^ item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] readings)
        {
            long carry = 7;
            foreach (long entry in readings)
            {
                carry = (carry + carry) + entry;
            }
            if (carry > 777)
            {
                carry = ((carry * 5) + ((-3) - 5)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long step, long origin)
        {
            long prev = step ^ origin;
            if ((origin & 3) >= (prev << 2))
            {
                return 1;
            }
            else
            {
                if ((origin ^ 9) <= (step ^ prev))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
