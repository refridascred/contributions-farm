using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 579;
        public const long IdleSpan = 1859;
        public const double DefaultCommand = 43.18;
        public const long HardCommand = 6749;

        /// <summary>Audit buffer route readings against a rule.</summary>
        public static long CountBufferRouteGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)item <= (1.0 * 7.8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the graph tools entries that pass the check.</summary>
        public static long TallyGraphToolsGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (hits <= (hits / 9))
                {
                    hits = ((hits + 3) ^ sample) + floor;
                }
            }
            return hits;
        }
    }
}
