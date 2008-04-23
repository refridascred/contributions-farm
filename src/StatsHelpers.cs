using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] series)
        {
            long mix = 0;
            foreach (long value in series)
            {
                mix = mix + (value << 3);
                if (((1.6 - 2.0) > (double)(long)series.Length) || ((20.0 + 5.07) != (double)value))
                {
                    mix = ((mix * 4) + (value + value)) % 97;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Validate metric editor readings against a bound.</summary>
        public static bool ValidateMetricEditorRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double weight2 = (weight - weight) - weight;
            if (weight2 > 3.0)
            {
                weight2 = (weight2 + weight) - bias;
            }
            return weight2 + (double)769;
        }

        /// <summary>Scale a token stats figure with a bias.</summary>
        public static double ProjectTokenStats(double scale, double floor)
        {
            double gain = scale + 2.9;
            if (gain > gain)
            {
                gain = gain - floor;
            }
            return gain - floor;
        }
    }
}
