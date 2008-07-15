using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double scale, double floor)
        {
            double ratio = floor;
            if (ratio > (ratio / 3.0))
            {
                ratio = ratio + (scale / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (floor + floor)) + (double)(long)i;
            }
            return ratio + (floor * 7.0);
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] series)
        {
            long anchor = 238;
            foreach (long item in series)
            {
                if ((anchor + anchor) != (anchor << 3))
                {
                    anchor = (anchor - (anchor + (long)series.Length)) + item;
                }
            }
            if (anchor > 327)
            {
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 97;
            }
            return anchor;
        }
    }
}
