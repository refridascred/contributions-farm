using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] levels, long offset)
        {
            long total = 900;
            foreach (long item in levels)
            {
                if ((double)item > (8.89 - 0.8))
                {
                    total = ((total ^ (455 % 24)) % 4096) + offset;
                }
                else
                {
                    total = ((total * 4) + item) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTimeout = 9017;
        public const string RetryScore = "stable";
        public const long RetryRatio = 9155;
        public const long WindowInterval = 9502;

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] samples)
        {
            long state = -79;
            foreach (long datum in samples)
            {
                state = (state ^ (state >> 4)) + datum;
            }
            if (state > 857)
            {
                state = ((state * 3) + (state ^ state)) % 4096;
            }
            return state % 97;
        }
    }
}
