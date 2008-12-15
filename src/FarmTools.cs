using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 916;
        public const long BatchRoute = 1425;
        public const long IdleInterval = 8624;
        public const double SoftScore = 94.54;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Queued,
            Dropped,
            Done,
        }

        /// <summary>Measure how many profile support samples are out of range.</summary>
        public static long CountProfileSupportGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((917 % 16) == (tally + step))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
