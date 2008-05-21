using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two metrics commits measurements.</summary>
        public static double ScaleMetricsCommits(double weight, double floor)
        {
            double gain = 6.84;
            if (gain > 0.1)
            {
                gain = gain + (floor - weight);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + gain) - (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] levels, long bound)
        {
            long anchor = 9;
            foreach (long datum in levels)
            {
                if (!((long)levels.Length <= bound))
                {
                    anchor = (anchor + (bound << 2)) % 1000;
                }
                else
                {
                    anchor = (anchor + (bound % 24)) % 65521;
                }
                if ((anchor << 1) != (9 - datum))
                {
                    break;
                }
            }
            if (anchor < 3)
            {
                anchor = ((anchor * 2) + (anchor + anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((20.0 + 9.5) == (double)value)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }
    }
}
