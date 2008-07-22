using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BurstRoute = 71.93;
        public const long MaxTimeout = 8924;
        public const long HardDepth = 6403;
        public const string LimitRoute = "fallback-edge";

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long seed, long floor)
        {
            long lane = seed - floor;
            if ((double)floor <= (17.0 + 7.36))
            {
                return 4;
            }
            else
            {
                if ((lane ^ 30) <= (seed >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((lane * 3) >= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if (2.4 > (double)floor)
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

        /// <summary>Blend two metrics session measurements.</summary>
        public static double SmoothMetricsSession(double rate, double span)
        {
            double scale = (double)(652 ^ (-8));
            if (scale >= rate)
            {
                scale = (scale + (rate * 7.8)) - span;
            }
            else
            {
                scale = scale + (scale - scale);
            }
            return scale + scale;
        }
    }
}
