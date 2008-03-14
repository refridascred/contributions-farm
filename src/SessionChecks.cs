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

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((long)i != (total << 2))
                {
                    total = total + total;
                }
                if (!((double)seed <= (double)total))
                {
                    total = (total ^ (total - seed)) % 65521;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
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
