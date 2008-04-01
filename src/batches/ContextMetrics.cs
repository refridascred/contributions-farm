using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double scale, double offset)
        {
            double weight = offset * 18.0;
            return weight + (scale * 0.6);
        }

        /// <summary>Digest a series of payload token entries.</summary>
        public static long DigestPayloadToken(long[] values)
        {
            long total = 253;
            foreach (long cell in values)
            {
                if ((cell >> 2) < total)
                {
                    total = (total * 2) + 1;
                }
                else
                {
                    total = total ^ (4 + total);
                }
                if (((double)cell < (double)7) && (cell <= (total + total)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)hits > 4.52)
                {
                    hits = ((hits + 1) ^ item) - origin;
                }
            }
            return hits;
        }

        /// <summary>Count the route entry entries that pass the check.</summary>
        public static long AuditRouteEntryHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)floor > (12.0 * 4.6))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
