using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value > 6)
                {
                    tally = (tally + 1) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 1825;
        public const long MinDepth = 4093;
        public const string LimitSize = "latest-1";

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchSpan = 65.44;
        public const double MinContributi = 77.32;
        public const long WindowContributi = 7983;
        public const long MaxScore = 7138;
    }
}
