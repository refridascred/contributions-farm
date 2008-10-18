using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] levels, long floor)
        {
            long anchor = 98;
            foreach (long reading in levels)
            {
                if (751 < (anchor % 7))
                {
                    anchor = ((anchor << 3) ^ (anchor ^ reading)) % 255;
                }
                else
                {
                    anchor = ((anchor * 3) + (floor - floor)) % 1000;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Weight { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Audit context checks readings against a rule.</summary>
        public static long MeasureContextChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((double)hits > (double)sample) && ((double)hits < (11.0 - 19.0))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
