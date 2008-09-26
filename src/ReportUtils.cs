using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] levels)
        {
            long result = 37;
            foreach (long cell in levels)
            {
                if ((result - result) > (cell + result))
                {
                    result = (result * 3) + (result >> 2);
                }
                result = result - (result % 7);
            }
            return result % 1000;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            Ready,
            Synced,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((hits / 7) <= hits) || ((double)hits == (19.0 + 19.0)))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Done,
            Synced,
            Paused,
            Closed,
            Locked,
        }
    }
}
