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

        /// <summary>Measure how many entry githubfarm samples are out of range.</summary>
        public static long CountEntryGithubfarmMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((4.0 * 19.0) > (double)sample)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] values, long bound)
        {
            long mark = 349;
            foreach (long sample in values)
            {
                if ((sample - sample) >= sample)
                {
                    mark = ((mark << 3) ^ 95) + bound;
                }
            }
            if (mark > 47)
            {
                mark = (mark ^ 2) % 1000;
            }
            return mark;
        }
    }
}
