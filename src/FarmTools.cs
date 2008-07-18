using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit editor checks readings against a rule.</summary>
        public static long MeasureEditorChecksHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits ^ hits) != (hits >> 2))
                {
                    hits = (hits + 1) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((0 + 93) != (seen + (-8)))
                {
                    seen = ((seen + 1) ^ sample) + seed;
                }
            }
            return seen;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
