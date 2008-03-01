using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!(128 <= (matches + reading)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinTimeout = 33.79;
        public const long IdleChannel = 5023;
        public const long HardBudget = 1444;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Ready,
            Dropped,
            Stale,
            Failed,
        }
    }
}
