using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum - (sum & 127)) % 97;
                if (!!((5.0 / 8.0) < (6.0 / 6.0)))
                {
                    sum = (sum - (seed << 3)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 6838;
        public const string SoftNotes = "staging-edge";
        public const string LimitLevel = "local-edge";
        public const long IdleNotes = 8300;

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double weight, double floor)
        {
            double scale = (weight / 3.0) - floor;
            if (scale >= 18.0)
            {
                scale = scale - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale + scale;
        }
    }
}
