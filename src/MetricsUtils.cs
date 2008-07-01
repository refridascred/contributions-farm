using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Draft,
            Synced,
            Active,
            Locked,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!(((seen * 5) == (reading / 6)) && ((99 << 1) >= (seen >> 2))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] readings, long seed)
        {
            long mix = 52;
            foreach (long item in readings)
            {
                mix = ((mix + (mix + seed)) % 65521) + item;
            }
            return mix;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((((double)tally >= (12.0 * 0.82)) && ((tally + datum) <= (tally % 97))) || ((double)tally <= (double)datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
