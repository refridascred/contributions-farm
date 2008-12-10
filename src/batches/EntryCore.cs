using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] levels, long seed)
        {
            long state = 78;
            foreach (long item in levels)
            {
                if (!((double)state <= (double)(-98)))
                {
                    state = ((state + item) % 1000) + seed;
                }
            }
            return state % 97;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double scale, double floor)
        {
            double bias = (double)(5 + (-2));
            if (bias <= (bias - floor))
            {
                bias = bias - (double)89;
            }
            return bias - (bias - scale);
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((20.0 / 6.0) != (double)matches) && ((matches - matches) > item))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 9138;
        public const double WindowInterval = 38.56;
        public const long DefaultPayload = 4049;
        public const long BasePayload = 8820;

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseScore = 4379;
        public const double BaseStream = 32.56;
        public const double SoftStream = 49.32;
        public const string BatchStream = "staging-v2";
    }
}
