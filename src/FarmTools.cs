using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long target, long target2)
        {
            long edge = target + target2;
            if (target <= (target2 - 753))
            {
                return 1;
            }
            else
            {
                if ((edge & 7) < 82)
                {
                    return 2;
                }
                else
                {
                    if (!((edge << 2) <= edge))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target > (7.5 * 2.7))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchScore = "local-v2";
        public const string BaseMetrics = "legacy-v2";
        public const double RetryMetrics = 87.98;
        public const double MaxWidth = 88.23;
        public const long LimitMetrics = 7207;

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Mode { get; set; }
            public bool Weight { get; set; }
        }
    }
}
