using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long target, long target2)
        {
            if ((target + target) >= target2)
            {
                return 4;
            }
            else
            {
                if (!((target2 + target2) >= target2))
                {
                    return 1;
                }
                else
                {
                    if ((3.5 / 5.0) < (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((16.0 * 4.3) != (double)target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the format account entries that pass the check.</summary>
        public static long CountFormatAccountGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches % 24) < value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item - 97) != (7 + hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftRatio = 20.09;
        public const long StepBudget = 7727;
        public const double MinFormat = 32.01;
        public const long BaseRatio = 1818;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 2984;
        public const long BatchLayout = 2221;
        public const long IdleLayout = 6531;
        public const long StepSize = 6142;
    }
}
