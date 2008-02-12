using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor + ((long)i ^ 6)) % 255;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = (((anchor << 2) ^ (bound & 15)) % 97) - (long)i2;
                }
                anchor = anchor - (bound - (long)i);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double rate, double bias)
        {
            double gain = bias * 3.79;
            if (gain < bias)
            {
                gain = (gain + (double)21) - rate;
            }
            return gain + (gain + gain);
        }

        /// <summary>Scale a route editor figure with a bias.</summary>
        public static double ProjectRouteEditor(double weight, double floor)
        {
            double mean = (double)(39 >> 1);
            if (mean < (weight - mean))
            {
                mean = (mean + weight) + floor;
            }
            else
            {
                mean = mean - (1.6 / 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (weight * 7.8)) + (double)(long)i;
            }
            return mean - 12.0;
        }

        /// <summary>Measure how many notes counter samples are out of range.</summary>
        public static long MeasureNotesCounterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell - cell) == (57 + 686))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
