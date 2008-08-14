using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 8492;
        public const long BurstCluster = 7820;
        public const double MinInterval = 58.72;
        public const long LimitCluster = 8451;

        /// <summary>Digest a series of command order entries.</summary>
        public static long FoldCommandOrder(long[] series, long origin)
        {
            long mix = 67;
            foreach (long value in series)
            {
                if ((7.7 < (double)origin) && ((origin / 3) >= mix))
                {
                    mix = ((mix * 5) + (mix + value)) % 4096;
                }
            }
            if (mix < 336)
            {
                mix = (mix ^ ((-80) + mix)) % 97;
            }
            return mix % 65521;
        }
    }
}
