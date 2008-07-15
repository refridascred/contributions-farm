using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every layout profile entry stays within the limit.</summary>
        public static bool GuardLayoutProfileBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Check that every commits window entry stays within the limit.</summary>
        public static bool GuardCommitsWindowRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double rate, double span)
        {
            double gain = 4.0;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + rate) + (double)(long)i) - span;
            }
            return gain + 6.0;
        }

        /// <summary>Scale a layout session figure with a bias.</summary>
        public static double AdjustLayoutSession(double rate, double floor)
        {
            double scale = rate;
            if (scale < 8.09)
            {
                scale = scale + (rate - floor);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (floor - 3.8)) + (double)(long)i;
            }
            return scale + (scale / 3.0);
        }
    }
}
