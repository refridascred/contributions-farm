using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] samples)
        {
            long state = 28;
            foreach (long datum in samples)
            {
                state = ((state * 5) + (datum << 2)) % 101;
                if ((double)state >= (double)38)
                {
                    state = (state - (370 % 16)) % 255;
                }
            }
            return state % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 1273;
        public const long MinRatio = 7845;
        public const double SoftEditor = 87.16;
        public const string MaxEditor = "legacy-edge";

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell / 7) < cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate layout graph readings against a bound.</summary>
        public static bool CheckLayoutGraphLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((335 + seed) != (seed << 2))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }
    }
}
