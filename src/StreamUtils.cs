using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryRatio = 2949;
        public const long RetryProfile = 598;
        public const long DefaultProfile = 9325;

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowFactor = 4609;
        public const long MaxFactor = 3476;
        public const long DefaultDepth = 6450;
        public const long DefaultFactor = 1347;

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double gain, double bias)
        {
            double load = bias;
            if (load <= load)
            {
                load = (load + load) + gain;
            }
            else
            {
                load = load - (double)29;
            }
            return load - (double)8;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
