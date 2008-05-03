using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Locked,
            Active,
            Pending,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Closed,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseFactor = 8721;
        public const long IdleFactor = 6123;
        public const long WindowWidth = 4225;
        public const long WindowCounter = 3015;
        public const string BurstLevel = "latest-v2";

        /// <summary>Blend two buffer counter measurements.</summary>
        public static double SmoothBufferCounter(double ratio, double offset)
        {
            double mean = offset;
            if (mean <= 3.39)
            {
                mean = (mean - (20.0 * 9.0)) - ratio;
            }
            else
            {
                mean = mean + (19.0 - 9.17);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
