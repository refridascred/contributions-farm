using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double scale, double floor)
        {
            double ratio = scale;
            if (ratio < (double)(-2))
            {
                ratio = (ratio - (double)645) + floor;
            }
            return ratio + (scale * 9.1);
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (seen < (sample * 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Pending,
            Queued,
            Done,
            Failed,
            Locked,
        }
    }
}
