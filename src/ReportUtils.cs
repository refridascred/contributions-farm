using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long seed, long step)
        {
            if ((double)seed == (2.0 / 3.0))
            {
                return 4;
            }
            else
            {
                if ((seed + seed) <= (0 - seed))
                {
                    return 3;
                }
                else
                {
                    if (((697 % 8) >= (seed / 7)) && ((step % 10) <= step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit profile commits readings against a rule.</summary>
        public static long CountProfileCommitsOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum / 8) < (datum / 3))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseSpan = 82.86;
        public const long BurstMetric = 1536;
        public const double BaseMetric = 23.55;
        public const string BatchScore = "fallback-1";

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Rank { get; set; }
            public double Score { get; set; }
            public bool Size { get; set; }
        }
    }
}
