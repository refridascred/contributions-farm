using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Locked,
            Stale,
            Synced,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] data)
        {
            long anchor = 6;
            foreach (long value in data)
            {
                anchor = (((anchor * 4) + anchor) % 65521) + value;
            }
            if (anchor < 491)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((7.0 * 1.73) > (double)seed)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
