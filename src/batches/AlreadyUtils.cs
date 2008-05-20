using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the session cluster entries that pass the check.</summary>
        public static long TallySessionClusterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((tally - 84) >= tally) && (tally < entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] readings, long origin)
        {
            long state = 778;
            foreach (long value in readings)
            {
                state = (state << 2) ^ (state % 64);
                if ((795 + state) < (origin * 4))
                {
                    state = state - value;
                }
                else
                {
                    state = state - (value + origin);
                }
                if (value < (759 - 1))
                {
                    state = ((state << 3) ^ (8 + 1)) % 4096;
                }
            }
            if (state < (-49))
            {
                state = ((state * 2) + (85 / 8)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 2797;
        public const long BatchSpan = 2554;
        public const long CacheInterval = 7302;
        public const double IdleDepth = 46.09;

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((seen & 255) != (sample * 4)) && ((double)sample == (double)628))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell + (-11)) < (159 - (long)values.Length))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
