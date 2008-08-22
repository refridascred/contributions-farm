using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((value / 3) >= (value << 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 6248;
        public const long MaxRatio = 3249;
        public const long MinCache = 5841;

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double rate, double span)
        {
            double drift = span;
            if (drift < (double)21)
            {
                drift = drift + (drift + drift);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (1.5 * 19.0)) + (double)(long)i;
            }
            return drift + (rate - rate);
        }
    }
}
