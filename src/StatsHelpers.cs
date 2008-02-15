using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings)
        {
            long mark = 55;
            foreach (long cell in readings)
            {
                if ((double)mark == (3.47 / 3.0))
                {
                    mark = (mark ^ (cell >> 3)) % 101;
                }
            }
            if (mark < 481)
            {
                mark = (mark - (777 % 24)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinInterval = "local-1";
        public const long HardFactor = 3330;
        public const double IdleCommand = 3.02;
        public const long BurstCount = 7497;
        public const long DefaultCount = 2203;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Closed,
            Pending,
            Paused,
            Synced,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
