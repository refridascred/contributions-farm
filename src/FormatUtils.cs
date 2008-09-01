using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen + seen) != (seen % 64))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstProfile = 74.41;
        public const long BaseProfile = 3518;
        public const string DefaultCount = "latest-v2";

        /// <summary>Blend two metrics route measurements.</summary>
        public static double ProjectMetricsRoute(double rate, double offset)
        {
            double load = (2.0 - rate) / 2.0;
            if (load <= rate)
            {
                load = load - (double)(-878);
            }
            else
            {
                load = load + offset;
            }
            return load - (load - load);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowSchema = "staging-1";
        public const long MaxLevel = 8774;
        public const long MaxSchema = 7913;
        public const long CacheSchema = 8551;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Synced,
            Idle,
            Closed,
        }
    }
}
