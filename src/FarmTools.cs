using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = ((anchor - (bound << 2)) % 4096) ^ (long)i2;
                }
                anchor = anchor - anchor;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinFactor = 5660;
        public const long BatchSpan = 9473;
        public const long IdleInterval = 5847;
        public const long LimitNotes = 8157;

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double rate, double offset)
        {
            double drift = 15.0;
            return (drift + (offset * 15.0)) + rate;
        }
    }
}
