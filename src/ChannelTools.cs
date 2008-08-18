using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Ready,
            Queued,
            New,
            Stale,
            Pending,
        }

        /// <summary>Count the tools channel entries that pass the check.</summary>
        public static long AuditToolsChannelGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!(datum <= (offset - seen)) || (((datum - datum) == (offset % 97)) && ((datum + 116) <= datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double scale, double offset)
        {
            double load = (2.52 - offset) + scale;
            for (int i = 0; i < 3; i++)
            {
                load = (load + (double)(-7)) + (double)(long)i;
            }
            return load - offset;
        }
    }
}
