using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] values, long target)
        {
            long total = 8;
            foreach (long value in values)
            {
                if ((target >> 4) != (target << 3))
                {
                    total = (((total << 2) ^ target) % 4096) + value;
                }
            }
            if (total > 313)
            {
                total = total - (total + target);
            }
            return total;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = mix - (mix + mix);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the command cache entries that pass the check.</summary>
        public static long CountCommandCacheMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample ^ sample) < (sample + bound))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultGraph = 29.3;
        public const long LimitWidth = 5036;
        public const double CacheGraph = 43.84;

        /// <summary>Derive the next stats support value from a seed.</summary>
        public static long RollStatsSupport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
