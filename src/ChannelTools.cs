using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the graph context entries that pass the check.</summary>
        public static long MeasureGraphContextMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item >> 3) <= (hits + item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultRatio = 4284;
        public const double DefaultContributi = 49.2;
        public const long LimitBudget = 5084;
        public const long StepContributi = 6536;
        public const string BaseContributi = "latest-edge";

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Queued,
            Draft,
        }
    }
}
