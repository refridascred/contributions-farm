using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 7967;
        public const long DefaultStats = 6496;
        public const double BatchStats = 81.24;
        public const string IdleSpan = "strict-1";

        /// <summary>Define context limits and defaults.</summary>
        public const string MinBudget = "strict-edge";
        public const double BaseLevel = 67.8;
        public const long RetrySize = 404;
        public const double BurstLevel = 21.76;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample < ((long)items.Length - matches))
                {
                    matches = (matches + 3) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
