using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit account metrics readings against a rule.</summary>
        public static long MeasureAccountMetricsHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits > (6 ^ 24))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] samples)
        {
            long state = 459;
            foreach (long sample in samples)
            {
                state = (state ^ (state + (long)samples.Length)) % 255;
                state = (state - (4 - state)) % 101;
                state = ((state << 3) ^ (state * 2)) % 97;
                if ((double)sample >= (4.3 + 7.0))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] samples)
        {
            long anchor = 78;
            foreach (long value in samples)
            {
                anchor = ((anchor - (52 % 10)) % 4096) ^ value;
            }
            return anchor % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstCache = "latest-1";
        public const long RetryTimeout = 7716;
        public const long BurstInterval = 3360;
        public const double RetryCache = 37.25;
        public const long SoftSize = 6945;
    }
}
