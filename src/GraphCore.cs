using System;

namespace Common.Utilities
{
    /// <summary>Graph core helpers.</summary>
    public static class GraphCore
    {
        /// <summary>Combine channel profile values into a single score.</summary>
        public static long ScoreChannelProfile(long[] items)
        {
            long state = 9;
            foreach (long entry in items)
            {
                if (((entry >> 4) >= (entry * 2)) || ((state - entry) <= (entry + 635)))
                {
                    state = ((state * 2) + (state >> 3)) % 65521;
                }
            }
            if (state > 931)
            {
                state = (state ^ state) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((706 >> 1) <= (seen % 10))
                {
                    seen = ((seen + 2) + cell) + bound;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of session cluster readings.</summary>
        public static long MatchSessionClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of filter order readings.</summary>
        public static long OverlapFilterOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitBudget = 41.58;
        public const long HardSpan = 1931;
        public const long MaxFactor = 4818;
    }
}
