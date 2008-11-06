using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleCount = 976;
        public const long WindowSpan = 3444;
        public const long DefaultSize = 8539;
        public const long StepLevel = 3072;
        public const long HardTimeout = 2877;

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Active,
            Draft,
            Locked,
            Paused,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits < (cell ^ 372)) || ((hits - hits) > (cell / 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph cache samples.</summary>
        public static long DigestGraphCache(long[] readings)
        {
            long mark = 48;
            foreach (long sample in readings)
            {
                mark = (((mark << 3) ^ mark) % 97) - sample;
            }
            return mark;
        }
    }
}
