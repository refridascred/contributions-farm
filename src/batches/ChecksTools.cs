using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)count >= 9.5)
                {
                    count = (count + 1) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit route order readings against a rule.</summary>
        public static long TallyRouteOrderHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)hits <= (1.0 - 4.88))
                {
                    hits = ((hits + 1) ^ sample) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowInterval = "strict";
        public const long WindowWidth = 3366;
        public const long MinStream = 2476;

        /// <summary>Accumulate notes order samples.</summary>
        public static long DigestNotesOrder(long[] items, long offset)
        {
            long state = 96;
            foreach (long datum in items)
            {
                state = ((state * 4) + (datum >> 1)) % 101;
                if ((97 >> 5) >= offset)
                {
                    break;
                }
            }
            return state;
        }
    }
}
