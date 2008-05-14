using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "local-v2";
        public const double IdleToken = 30.6;
        public const double MinWidth = 12.59;
        public const long BurstFactor = 9356;

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Owner { get; set; }
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count the channel entry entries that pass the check.</summary>
        public static long CountChannelEntryMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!(((reading - hits) >= (hits - seed)) && ((4.1 * 17.0) != (double)seed)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
