using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the token layout entries that pass the check.</summary>
        public static long MeasureTokenLayoutOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)cell != (1.0 + 15.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((long)items.Length <= (hits >> 5))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }
    }
}
