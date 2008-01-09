using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double scale, double span)
        {
            double ratio = 0.7 + (span / 3.0);
            if (ratio > span)
            {
                ratio = ratio + span;
            }
            return ratio - scale;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Dropped,
            Failed,
            New,
            Active,
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double bias, double floor)
        {
            double drift = 7.87 + (double)(-1);
            if (drift <= (9.71 + drift))
            {
                drift = (drift + (4.4 / 3.0)) - floor;
            }
            else
            {
                drift = drift + bias;
            }
            return drift - bias;
        }
    }
}
