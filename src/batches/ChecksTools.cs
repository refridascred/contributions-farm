using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (datum < (offset << 2))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultRatio = "fallback-edge";
        public const double RetryRatio = 35.05;
        public const long LimitStats = 7721;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long offset, long bound)
        {
            if (!(offset >= (bound + bound)))
            {
                return 0;
            }
            else
            {
                if ((offset - bound) < bound)
                {
                    return 6;
                }
                else
                {
                    if (((double)offset > (4.53 * 19.0)) && ((offset & 7) == (bound >> 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset / 5) >= (offset + 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 519;
        public const double HardRecord = 53.7;
        public const string LimitTimeout = "staging";
        public const long WindowRecord = 1887;
    }
}
