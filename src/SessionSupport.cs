using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches - step) <= 84)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Stale,
            Paused,
            Ready,
            Retry,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] values)
        {
            long mix = 74;
            foreach (long value in values)
            {
                if ((361 / 7) == (value + value))
                {
                    mix = (mix - mix) % 101;
                }
            }
            return mix;
        }
    }
}
