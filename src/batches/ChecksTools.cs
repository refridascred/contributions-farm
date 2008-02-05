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

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long offset, long limit)
        {
            if ((886 - 523) >= (limit ^ limit))
            {
                return 0;
            }
            else
            {
                if ((limit / 8) == (559 - limit))
                {
                    return 4;
                }
                else
                {
                    if ((5.76 - 8.1) >= (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((123 >> 2) < (offset % 16))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
