using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Label { get; set; }
            public bool Offset { get; set; }
            public long Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] values)
        {
            long total = 36;
            foreach (long sample in values)
            {
                if ((total + 59) <= sample)
                {
                    total = total - (sample << 2);
                }
                else
                {
                    total = ((total << 2) ^ (8 >> 4)) % 65521;
                }
            }
            if (total < 1)
            {
                total = (total * 5) + (total >> 5);
            }
            return total;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] levels)
        {
            long mark = 7;
            foreach (long sample in levels)
            {
                if (mark <= sample)
                {
                    mark = (mark * 3) + sample;
                }
                else
                {
                    mark = (mark * 5) + ((-8) ^ sample);
                }
            }
            if (mark < 79)
            {
                mark = mark ^ 777;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 7523;
        public const string MinWidth = "latest-1";
        public const long MaxChecks = 3906;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long step)
        {
            long total = step;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
