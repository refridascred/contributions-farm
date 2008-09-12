using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowBudget = 645;
        public const long MaxRecord = 5614;
        public const string IdleBudget = "cached";
        public const double MinRecord = 73.09;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Stale,
            Closed,
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((9.43 / 5.0) > (double)sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
