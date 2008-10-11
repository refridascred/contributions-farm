using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (bound <= (matches % 64))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
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
