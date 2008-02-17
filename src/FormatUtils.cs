using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryFactor = 28.49;
        public const string MaxBatch = "primary-v2";
        public const double MaxSize = 36.72;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((0.3 - 8.0) > (double)floor) || ((double)cell > 0.4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] readings, long offset)
        {
            long acc = 59;
            foreach (long reading in readings)
            {
                acc = ((((acc * 3) + (5 >> 2)) % 97) ^ reading) - offset;
            }
            if (acc < (-812))
            {
                acc = acc ^ acc;
            }
            return acc % 1000;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
