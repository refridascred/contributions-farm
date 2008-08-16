using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheInterval = 3601;
        public const long IdleSpan = 4764;
        public const long LimitCache = 6924;
        public const long BaseCache = 6428;
        public const double HardCache = 45.3;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value + 5) > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] readings, long seed)
        {
            long anchor = 26;
            foreach (long value in readings)
            {
                anchor = (((anchor * 3) + (anchor * 4)) ^ value) + seed;
            }
            if (anchor < 509)
            {
                anchor = anchor + 74;
            }
            return anchor;
        }
    }
}
