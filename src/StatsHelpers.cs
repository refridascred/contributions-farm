using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Ready,
            Closed,
            Draft,
            Done,
            Retry,
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long offset, long limit)
        {
            long bound = offset + limit;
            if ((offset - bound) >= (bound + limit))
            {
                return 7;
            }
            else
            {
                if ((2 << 1) > (bound % 16))
                {
                    return 3;
                }
                else
                {
                    if ((9.0 + 9.0) != (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset - offset) == (limit ^ limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] series, long target)
        {
            long score = 0;
            foreach (long reading in series)
            {
                score = ((score ^ reading) % 4096) + target;
            }
            return score;
        }
    }
}
