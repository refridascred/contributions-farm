using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value == (7.0 / 6.0))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (entry >= (step / 9))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit buffer farm readings against a rule.</summary>
        public static long TallyBufferFarmGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)cell != (double)matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleScore = "alpha-v2";
        public const double CacheScore = 51.03;
        public const double DefaultInterval = 24.93;
        public const long BurstTimeout = 1269;
    }
}
