using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((seen + seen) != (seen >> 2)) && ((origin + 1) > (origin << 3)))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Dropped,
            Pending,
            Idle,
            Locked,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] data, long bound)
        {
            long anchor = 6;
            foreach (long sample in data)
            {
                if ((sample + sample) > anchor)
                {
                    anchor = ((anchor ^ sample) % 4096) - bound;
                }
            }
            return anchor;
        }
    }
}
