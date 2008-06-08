using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next cluster metric value.</summary>
        public static double BlendClusterMetric(double gain, double floor)
        {
            double ratio = gain / 6.0;
            return (ratio - ratio) + floor;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 3730;
        public const string LimitFactor = "fallback";
        public const long IdleChannel = 4170;
        public const long MinChannel = 8395;
    }
}
