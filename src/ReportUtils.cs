using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 9271;
        public const double IdleRatio = 12.7;
        public const long BaseAlready = 5607;
        public const double HardAlready = 40.01;
        public const long MaxRatio = 1156;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetrySize = 5368;
        public const double BatchSpan = 36.02;
        public const double BurstBudget = 22.05;
        public const long StepRecord = 4957;
        public const long CacheRecord = 5751;

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
            public bool Owner { get; set; }
            public bool Token { get; set; }
        }
    }
}
