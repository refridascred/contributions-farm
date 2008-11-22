using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit tools buffer readings against a rule.</summary>
        public static long TallyToolsBufferHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum & 127) >= bound)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((2.0 / 3.0) > (double)limit)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] samples)
        {
            long mix = 1;
            foreach (long sample in samples)
            {
                mix = (mix - (long)samples.Length) % 4096;
                mix = (mix ^ (sample & 7)) % 4096;
                mix = mix - 425;
            }
            return mix;
        }

        /// <summary>Digest a series of route token entries.</summary>
        public static long DigestRouteToken(long[] series)
        {
            long sum = 715;
            foreach (long entry in series)
            {
                if (entry <= (sum ^ entry))
                {
                    sum = sum + (entry + entry);
                }
            }
            return sum;
        }
    }
}
