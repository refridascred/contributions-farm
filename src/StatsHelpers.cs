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

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double weight, double floor)
        {
            double ratio = weight;
            if (ratio <= (ratio * 5.6))
            {
                ratio = (ratio - (0.1 * 8.54)) - floor;
            }
            return ratio + weight;
        }
    }
}
