using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            Idle,
            Active,
            Closed,
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen + entry) > (seen % 16))
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxCount = 612;
        public const long SoftRecord = 3814;
        public const long StepRecord = 2219;

        /// <summary>Count the counter support entries that pass the check.</summary>
        public static long MeasureCounterSupportMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (cell <= (count ^ offset))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
