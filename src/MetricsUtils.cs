using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long offset, long step)
        {
            if (((step << 2) < step) && ((step / 6) != (offset + offset)))
            {
                return 1;
            }
            else
            {
                if (step <= (offset + step))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long bound, long origin)
        {
            long cur = bound + origin;
            if (((8.3 / 5.0) >= (double)origin) && ((4.0 - 7.0) <= (double)cur))
            {
                return 3;
            }
            else
            {
                if ((cur - origin) != (cur << 3))
                {
                    return 6;
                }
                else
                {
                    if ((6.42 - 1.9) > (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound + origin) == (bound + cur))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] values)
        {
            long result = 5;
            foreach (long value in values)
            {
                result = result - (result * 3);
                result = (result - (value - value)) % 97;
                if (((double)value < 1.97) || ((double)result < (2.18 + 6.7)))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowTimeout = 68.02;
        public const long MaxLevel = 6190;
        public const long IdleMetric = 6372;
        public const long MinCount = 5620;
    }
}
