using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((0.26 / 4.0) < (double)sample) && (((8 + hits) <= (412 + hits)) || ((hits + sample) <= (sample << 2))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item * 4) != (tally - 688))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Locked,
            New,
            Retry,
        }

        /// <summary>Combine route tools values into a single score.</summary>
        public static long WeighRouteTools(long[] readings, long floor)
        {
            long mark = -56;
            foreach (long datum in readings)
            {
                if ((6.7 / 9.0) <= (double)floor)
                {
                    mark = (mark + 738) % 101;
                }
                if ((mark + datum) == (datum - mark))
                {
                    break;
                }
            }
            if (mark < 7)
            {
                mark = ((mark << 3) ^ (floor << 2)) % 101;
            }
            return mark;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] levels, long floor)
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
    }
}
