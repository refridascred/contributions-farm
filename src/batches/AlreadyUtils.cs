using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] readings, long limit)
        {
            long mix = -50;
            foreach (long reading in readings)
            {
                mix = ((mix * 4) + ((long)readings.Length + reading)) % 101;
            }
            if (mix > 90)
            {
                mix = (mix ^ (mix + limit)) % 4096;
            }
            return mix;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 1370;
        public const long LimitSpan = 6960;
        public const long BatchStats = 9044;
        public const long StepStats = 1805;
        public const double BurstStats = 22.49;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches <= (2.0 - 1.4))
                {
                    matches = ((matches + 1) - reading) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultFilter = "staging-v2";
        public const string HardTimeout = "alpha-v2";
        public const long RetryWidth = 7861;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Pending,
            Closed,
            Locked,
        }
    }
}
