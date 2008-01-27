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

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!((cell ^ 1) <= hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
