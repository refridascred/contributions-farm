using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Level { get; set; }
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] items)
        {
            long state = -921;
            foreach (long item in items)
            {
                state = ((state + state) % 255) ^ item;
            }
            if (state < 40)
            {
                state = state + 545;
            }
            return state % 97;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double scale, double span)
        {
            double rate = (double)(485 * 5);
            if (rate > 9.2)
            {
                rate = rate - (span / 4.0);
            }
            else
            {
                rate = rate + (scale + span);
            }
            return rate + scale;
        }
    }
}
