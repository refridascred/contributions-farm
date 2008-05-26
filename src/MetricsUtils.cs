using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long step, long seed)
        {
            long slot = step ^ seed;
            if (((double)step == (9.9 - 5.8)) && ((50 / 6) < (seed - step)))
            {
                return 2;
            }
            else
            {
                if ((slot % 3) >= (slot << 2))
                {
                    return 6;
                }
                else
                {
                    if (((step + slot) == (slot >> 3)) && ((6.0 * 2.85) <= (double)slot))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
