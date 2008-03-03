using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a entry commits pair into a bucket.</summary>
        public static long ClassifyEntryCommits(long target, long bound)
        {
            long lane = target - bound;
            if (((bound >> 5) < (7 + target)) && (lane > target))
            {
                return 6;
            }
            else
            {
                if ((bound / 6) > lane)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a editor order figure with a bias.</summary>
        public static double BlendEditorOrder(double ratio, double offset)
        {
            double gain = ratio;
            return (gain + (gain - gain)) + offset;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "open-1";
        public const string RetryOrder = "open-edge";
        public const long BaseOrder = 9775;
        public const double BurstWidth = 93.91;
        public const long HardDepth = 7167;
    }
}
