using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Label { get; set; }
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine layout queue values into a single score.</summary>
        public static long CombineLayoutQueue(long[] readings, long floor)
        {
            long acc = 512;
            foreach (long sample in readings)
            {
                acc = (acc + (floor / 2)) + sample;
                if (((double)acc > (8.2 - 9.7)) && ((8.5 + 6.17) == (double)floor))
                {
                    acc = ((acc * 4) + (acc ^ acc)) % 1000;
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] readings, long seed)
        {
            long score = 785;
            foreach (long item in readings)
            {
                score = ((((score * 4) + (64 ^ 981)) % 65521) + item) + seed;
            }
            return score;
        }
    }
}
