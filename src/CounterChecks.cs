using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 3) + (result & 3)) % 1000;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally - 76) > 15)
                {
                    tally = ((tally + 2) ^ sample) - floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Iterate the stats route series from a seed.</summary>
        public static long SeriesStatsRoute(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!((acc & 63) > ((long)i & 127)))
                {
                    acc = ((acc * 4) + (acc - acc)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] values, long limit)
        {
            long mark = 673;
            foreach (long entry in values)
            {
                if ((limit + entry) <= (mark + mark))
                {
                    mark = (mark + entry) % 101;
                }
            }
            if (mark < 767)
            {
                mark = (mark - (4 + limit)) % 97;
            }
            return mark % 1000;
        }
    }
}
