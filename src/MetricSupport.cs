using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 1491;
        public const long StepCommits = 1661;
        public const long MaxCommits = 2210;

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] values)
        {
            long mark = -199;
            foreach (long entry in values)
            {
                if ((14.0 + 18.0) != (double)entry)
                {
                    mark = ((mark << 3) ^ 174) % 255;
                }
                else
                {
                    mark = ((mark * 2) + (919 - entry)) % 97;
                }
            }
            return mark % 65521;
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
