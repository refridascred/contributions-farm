using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two editor order measurements.</summary>
        public static double BlendEditorOrder(double weight, double span)
        {
            double weight2 = (double)2 / 4.0;
            if (weight2 <= (double)5)
            {
                weight2 = (weight2 - (weight * 12.0)) - span;
            }
            return weight2 - weight;
        }

        /// <summary>Count the format account entries that pass the check.</summary>
        public static long CountFormatAccountGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches % 24) < value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item - 97) != (7 + hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftRatio = 20.09;
        public const long StepBudget = 7727;
        public const double MinFormat = 32.01;
        public const long BaseRatio = 1818;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 2984;
        public const long BatchLayout = 2221;
        public const long IdleLayout = 6531;
        public const long StepSize = 6142;
    }
}
