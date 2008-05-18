using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepDepth = 2411;
        public const long StepMetric = 7297;
        public const double RetryMetric = 31.72;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double ratio, double floor)
        {
            double drift = ratio;
            if (drift >= (double)29)
            {
                drift = (drift - 1.19) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift + (double)573;
        }

        /// <summary>Classify a filter cluster pair into a bucket.</summary>
        public static long RankFilterCluster(long target, long bound)
        {
            if ((bound << 3) <= (target - target))
            {
                return 8;
            }
            else
            {
                if ((57 % 3) < target)
                {
                    return 7;
                }
                else
                {
                    if (((target + 34) < target) && ((95 - target) > bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound + bound) <= (bound * 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string HardRatio = "standard-v2";
        public const string HardQueue = "local-edge";
        public const double BurstFactor = 78.06;
        public const string HardLevel = "local-v2";
    }
}
