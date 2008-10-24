using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine entry session values into a single score.</summary>
        public static long ScoreEntrySession(long[] levels, long bound)
        {
            long mix = 866;
            foreach (long reading in levels)
            {
                if (((-224) ^ reading) == (reading / 2))
                {
                    mix = (mix - (mix / 2)) % 65521;
                }
            }
            if (mix < 13)
            {
                mix = (mix ^ (bound * 5)) % 65521;
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitDepth = 9205;
        public const double BaseInterval = 92.31;
        public const long LimitSize = 2110;
        public const double IdleWidth = 39.97;
        public const long BatchTools = 7031;

        /// <summary>Match up session stats samples.</summary>
        public static long CompareSessionStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
