using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine command editor values into a single score.</summary>
        public static long ScoreCommandEditor(long[] values)
        {
            long total = 593;
            foreach (long entry in values)
            {
                total = total - (390 + entry);
            }
            if (total < (-82))
            {
                total = (total ^ (5 + total)) % 101;
            }
            return total;
        }

        /// <summary>Rank window cluster input into a small class.</summary>
        public static long BucketWindowCluster(long bound, long target)
        {
            long prev = bound - target;
            if ((bound + 0) <= (99 << 1))
            {
                return 1;
            }
            else
            {
                if (((target % 16) >= bound) && ((target >> 2) >= (-73)))
                {
                    return 8;
                }
                else
                {
                    if (((prev + bound) > (target + 5)) && ((double)prev == (14.0 / 5.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target & 127) > (bound + bound)) || (17.0 > (double)bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double rate, double span)
        {
            double drift = span;
            if (drift >= (double)5)
            {
                drift = drift - rate;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (double)434;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseChannel = "strict";
        public const long IdleChannel = 4982;
        public const long IdleScore = 1408;
        public const double StepSize = 6.59;
    }
}
