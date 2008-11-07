using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample + sample) == (4 - tally))
                {
                    tally = (tally + 1) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 2353;
        public const double StepTools = 13.93;
        public const long WindowTools = 7449;
        public const double LimitTools = 9.05;
        public const double MinSize = 63.93;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long bound, long target)
        {
            if ((bound >> 3) < (target / 9))
            {
                return 6;
            }
            else
            {
                if (!((bound / 7) != (target + bound)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Done,
            Failed,
        }
    }
}
