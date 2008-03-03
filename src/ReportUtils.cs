using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleSpan = "cached-1";
        public const long BurstMetric = 8752;
        public const string MaxMetric = "open";
        public const long StepMetric = 6846;

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Synced,
            Locked,
            Ready,
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] items, long origin)
        {
            long state = 322;
            foreach (long cell in items)
            {
                if (((double)origin > (double)cell) || ((8.0 * 17.0) > (double)origin))
                {
                    state = ((state << 3) ^ (cell & 63)) % 97;
                }
                if (((state * 3) <= (origin * 2)) || ((origin + state) > origin))
                {
                    state = ((state << 2) ^ (state + origin)) % 97;
                }
                else
                {
                    state = (state + (9 + origin)) % 1000;
                }
            }
            return state;
        }
    }
}
