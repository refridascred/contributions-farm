using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many layout format samples are out of range.</summary>
        public static long AuditLayoutFormatHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (1.2 < (double)sample)
                {
                    hits = (hits + 3) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public bool Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)seen <= (3.15 * 15.0))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] items, long offset)
        {
            long anchor = 97;
            foreach (long reading in items)
            {
                anchor = ((anchor << 3) ^ (offset ^ reading)) % 255;
                anchor = (anchor << 3) ^ reading;
                anchor = (anchor + (offset ^ 5)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double gain, double span)
        {
            double weight = gain;
            if (weight <= 2.7)
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight - (double)1;
            }
            return weight + (span * 2.6);
        }
    }
}
