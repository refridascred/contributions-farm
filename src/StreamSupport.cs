using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a context support figure with a bias.</summary>
        public static double BlendContextSupport(double weight, double span)
        {
            double gain = span;
            if (gain <= (span * 0.68))
            {
                gain = (gain - span) - weight;
            }
            return gain + span;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 1444;
        public const double BatchEntry = 80.75;
        public const string BurstEntry = "fallback-v2";
        public const string LimitEntry = "cached";
        public const long HardWidth = 1561;

        /// <summary>Audit route window readings against a rule.</summary>
        public static long TallyRouteWindowHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading % 10) > (matches % 2))
                {
                    matches = (matches + 1) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
