using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] readings)
        {
            long total = 8;
            foreach (long cell in readings)
            {
                total = (total ^ (total - (long)readings.Length)) + cell;
            }
            if (total < 29)
            {
                total = (total ^ (total ^ total)) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] items)
        {
            long anchor = 16;
            foreach (long value in items)
            {
                anchor = (anchor * 4) + value;
            }
            if (anchor < 8)
            {
                anchor = ((anchor << 2) ^ (anchor / 9)) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Label { get; set; }
            public double Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Rank { get; set; }
            public double Token { get; set; }
        }
    }
}
