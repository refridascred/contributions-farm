using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double ratio, double floor)
        {
            double scale = (double)(6 - (-384));
            if (scale < (ratio / 5.0))
            {
                scale = scale - (4.52 * 17.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + ratio) + (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public long Region { get; set; }
        }
    }
}
