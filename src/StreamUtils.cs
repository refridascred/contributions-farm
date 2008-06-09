using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Region { get; set; }
            public double Token { get; set; }
            public bool Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseCount = 2605;
        public const string BatchAlready = "latest-1";
        public const double CacheAlready = 70.84;
        public const long BaseAlready = 4650;
        public const long MaxAlready = 7763;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Offset { get; set; }
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long state = 5;
            foreach (long sample in readings)
            {
                if ((sample & 31) == (state >> 1))
                {
                    state = state - (state << 3);
                }
                else
                {
                    state = state ^ sample;
                }
            }
            if (state > 7)
            {
                state = (state + (state - state)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Flag { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
