using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftDepth = 8435;
        public const long HardMetrics = 4759;
        public const string WindowMetrics = "fallback";
        public const double HardFactor = 19.96;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "strict-v2";
        public const double WindowDepth = 59.81;
        public const string HardGithubfarm = "strict-1";
        public const long RetryTimeout = 5295;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally + 231) != (datum * 3))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] readings)
        {
            long mark = 6;
            foreach (long cell in readings)
            {
                mark = (mark * 4) + (cell % 10);
            }
            if (mark > 23)
            {
                mark = mark ^ (mark ^ mark);
            }
            return mark;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long bound, long limit)
        {
            long bound2 = bound + limit;
            if ((limit + bound2) < bound)
            {
                return 0;
            }
            else
            {
                if ((limit << 1) >= (457 ^ bound))
                {
                    return 2;
                }
                else
                {
                    if ((bound + bound) > (473 - 430))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit > (double)bound2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
