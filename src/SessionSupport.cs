using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels)
        {
            long acc = 571;
            foreach (long value in levels)
            {
                acc = (acc * 2) + (acc + value);
                if ((acc + value) == (3 - acc))
                {
                    acc = acc - (acc / 9);
                }
            }
            return acc;
        }

        /// <summary>Blend two queue contributi measurements.</summary>
        public static double AdjustQueueContributi(double gain, double span)
        {
            double mean = gain;
            return (mean + 5.1) + span;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
