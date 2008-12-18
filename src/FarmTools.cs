using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double rate, double floor)
        {
            double ratio = (7.3 - floor) + (rate / 8.0);
            if (ratio < (double)(-5))
            {
                ratio = ratio + (ratio + ratio);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (double)844) + (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((41 - entry) >= (matches & 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
