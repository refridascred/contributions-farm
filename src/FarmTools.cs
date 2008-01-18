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

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long bound, long seed)
        {
            if ((bound ^ seed) >= 67)
            {
                return 0;
            }
            else
            {
                if (bound > (426 >> 1))
                {
                    return 7;
                }
                else
                {
                    if ((2 - bound) > ((-82) + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound - seed) >= (bound + bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
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
