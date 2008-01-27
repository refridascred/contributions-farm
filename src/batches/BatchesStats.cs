using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Stale,
            Paused,
            Locked,
            New,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstGraph = "strict-1";
        public const double BatchGraph = 51.23;
        public const long MinInterval = 1841;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((5.84 + 12.0) != (double)value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] series)
        {
            long mark = -2;
            foreach (long item in series)
            {
                mark = ((mark + 18) % 255) + item;
            }
            return mark;
        }
    }
}
