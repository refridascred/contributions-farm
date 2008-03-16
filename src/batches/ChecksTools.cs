using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            Ready,
            Draft,
            Dropped,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstSpan = 3193;
        public const long DefaultStream = 5505;
        public const long CacheStream = 9;
        public const long StepCount = 5361;
        public const long HardStream = 2572;

        /// <summary>Measure how many notes stats samples are out of range.</summary>
        public static long TallyNotesStatsOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)item == (double)768)
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] items, long origin)
        {
            long state = 139;
            foreach (long datum in items)
            {
                if ((datum & 15) > origin)
                {
                    state = ((state * 5) + (49 >> 1)) % 1000;
                }
            }
            return state;
        }
    }
}
