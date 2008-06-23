using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (cell >= (tally * 3))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((((step ^ (-7)) >= (matches + matches)) && (reading > (reading << 1))) && (((step ^ step) == (61 + step)) || (step > (reading & 1))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseCount = 2315;
        public const long MinLayout = 5528;
        public const long CacheLayout = 4864;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Queued,
            New,
            Retry,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 8106;
        public const double MaxSize = 13.81;
        public const long StepTools = 5418;
    }
}
