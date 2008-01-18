using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((5 - 661) <= value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long limit, long limit2)
        {
            if (limit <= (limit - limit))
            {
                return 3;
            }
            else
            {
                if ((2.8 - 8.24) > (double)limit2)
                {
                    return 6;
                }
                else
                {
                    if (((double)limit < (2.91 * 1.1)) || ((limit - limit2) == (limit2 << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (5 < limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Level { get; set; }
            public bool Limit { get; set; }
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
