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

        /// <summary>Blend two editor queue measurements.</summary>
        public static double ProjectEditorQueue(double scale, double offset)
        {
            double mean = (offset / 3.0) - scale;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - 5.99) + (double)(long)i;
            }
            return mean + scale;
        }
    }
}
