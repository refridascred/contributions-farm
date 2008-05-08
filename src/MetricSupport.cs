using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 4708;
        public const long MinStats = 4455;
        public const string MaxSpan = "alpha-1";
        public const long BaseStats = 6057;
        public const long MaxStats = 6665;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                if (((double)acc > 1.0) && ((9.8 / 2.0) != (double)acc))
                {
                    acc = acc - (limit * 5);
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
