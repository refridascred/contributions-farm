using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((((floor + cell) >= (seen & 7)) && ((seen - cell) == (cell << 1))) || !((90 << 3) <= (cell << 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Total { get; set; }
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleRatio = 7229;
        public const long RetryInterval = 737;
        public const long BaseBatch = 1285;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double ratio, double span)
        {
            double bias = span;
            if (bias < (ratio + ratio))
            {
                bias = bias + (span - ratio);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (ratio / 9.0)) + (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Level { get; set; }
            public double Flag { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
        }
    }
}
