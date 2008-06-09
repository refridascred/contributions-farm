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

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (5.21 >= (double)offset)
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

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
