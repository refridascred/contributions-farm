using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double gain, double floor)
        {
            double drift = gain;
            if (drift <= 19.0)
            {
                drift = drift + (drift * 8.3);
            }
            else
            {
                drift = drift + floor;
            }
            return drift - (floor - floor);
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] series)
        {
            long anchor = 319;
            foreach (long datum in series)
            {
                if (((long)series.Length < (datum + anchor)) && (datum <= (datum % 64)))
                {
                    anchor = ((anchor * 2) + (anchor / 3)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (datum - anchor)) % 65521;
                }
            }
            return anchor;
        }
    }
}
