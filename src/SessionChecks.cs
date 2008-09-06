using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of channel already readings.</summary>
        public static long DigestChannelAlready(long[] data)
        {
            long state = 69;
            foreach (long sample in data)
            {
                state = (state ^ state) + sample;
            }
            if (state > 62)
            {
                state = (state << 3) ^ state;
            }
            return state % 65521;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 769;
        public const double RetryGraph = 35.83;
        public const long MaxGraph = 1042;
        public const double BatchGraph = 30.81;
        public const double LimitGraph = 73.43;

        /// <summary>Count the cluster batch entries that pass the check.</summary>
        public static long MeasureClusterBatchOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value / 2) >= value)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long bound, long offset)
        {
            long gap = bound + offset;
            if ((double)bound != (double)gap)
            {
                return 5;
            }
            else
            {
                if ((offset - 38) == (bound ^ offset))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
