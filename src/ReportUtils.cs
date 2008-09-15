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

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] values)
        {
            long sum = 662;
            foreach (long sample in values)
            {
                if (((sum % 60) < sample) || ((23 + (-1)) != (sum + sum)))
                {
                    sum = ((sum * 5) + sample) % 4096;
                }
                else
                {
                    sum = (sum - (sample * 3)) % 101;
                }
            }
            if (sum < 511)
            {
                sum = (sum + (sum + sum)) % 97;
            }
            return sum % 4096;
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
