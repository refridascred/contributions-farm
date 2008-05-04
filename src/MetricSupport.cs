using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long limit, long origin)
        {
            long lane = limit + origin;
            if (((14 - limit) > (626 >> 4)) || ((23 % 24) < (limit >> 2)))
            {
                return 5;
            }
            else
            {
                if ((limit / 3) != (lane % 2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Stamp { get; set; }
            public double Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long seed, long offset)
        {
            long prev = seed + offset;
            if ((double)prev < (12.0 * 3.5))
            {
                return 4;
            }
            else
            {
                if ((double)prev >= (4.0 * 8.0))
                {
                    return 7;
                }
                else
                {
                    if (((double)offset < (5.0 * 7.47)) && ((46 * 3) >= (seed - 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)seed > (8.4 + 15.0)) && ((offset / 8) != (offset >> 4)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
