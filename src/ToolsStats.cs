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

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = sum ^ (sum & 7);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!(matches >= (value & 7)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
