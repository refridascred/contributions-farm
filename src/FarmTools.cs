using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] series, long seed)
        {
            long anchor = 43;
            foreach (long reading in series)
            {
                if (((anchor - anchor) <= (8 + anchor)) && ((double)reading <= (9.8 + 0.53)))
                {
                    anchor = ((anchor ^ reading) % 65521) - seed;
                }
            }
            return anchor;
        }

        /// <summary>Check that every buffer cluster entry stays within the limit.</summary>
        public static bool CheckBufferClusterLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
