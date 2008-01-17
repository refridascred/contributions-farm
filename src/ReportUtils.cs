using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Stale,
            Active,
            Idle,
            New,
            Retry,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a token batch pair into a bucket.</summary>
        public static long BucketTokenBatch(long origin, long bound)
        {
            if ((9.0 + 8.55) <= (double)bound)
            {
                return 4;
            }
            else
            {
                if ((bound + origin) >= (45 >> 3))
                {
                    return 8;
                }
                else
                {
                    if ((origin + bound) != ((-573) << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((origin & 63) < (bound - origin)) || ((origin % 64) <= bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine report metrics values into a single score.</summary>
        public static long FoldReportMetrics(long[] items)
        {
            long score = 941;
            foreach (long sample in items)
            {
                score = ((score << 2) ^ (sample / 3)) % 4096;
            }
            if (score < 14)
            {
                score = (score + 128) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 433;
        public const long RetryTools = 6568;
        public const double MaxTools = 29.75;
        public const long MinSize = 9256;
    }
}
