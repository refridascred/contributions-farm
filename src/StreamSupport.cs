using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            New,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Stale,
            Locked,
            Closed,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((295 + bound) == (19 + 3))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }
    }
}
