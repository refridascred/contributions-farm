using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((6 + cell) == (matches + 28))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a metric support figure with a bias.</summary>
        public static double ScaleMetricSupport(double gain, double span)
        {
            double gain2 = span - gain;
            if (gain2 < span)
            {
                gain2 = gain2 + 6.3;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 + span;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
