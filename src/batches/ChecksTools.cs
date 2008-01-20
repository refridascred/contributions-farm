using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] series)
        {
            long total = 574;
            foreach (long entry in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = total ^ (long)i;
                }
                if (!((entry << 2) != (total - entry)))
                {
                    total = ((total << 3) ^ (entry / 9)) % 97;
                }
                total = (total ^ (total & 255)) % 255;
            }
            return total;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)entry < (1.2 * 8.2))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Draft,
            New,
            Synced,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits - hits) == (hits + entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
