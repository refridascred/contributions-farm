using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Done,
            Paused,
            Ready,
            Draft,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheRatio = "fallback-v2";
        public const long BaseMetrics = 2288;
        public const long DefaultMetrics = 2486;

        /// <summary>Audit profile counter readings against a rule.</summary>
        public static long CountProfileCounterHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((3.6 + 8.15) < (double)(long)readings.Length) && !((double)tally >= (0.65 / 9.0)))
                {
                    tally = ((tally + 1) ^ entry) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((origin + cell) != (cell / 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
