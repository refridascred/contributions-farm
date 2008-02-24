using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many stream layout samples are out of range.</summary>
        public static long AuditStreamLayoutMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum - 3) < datum)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i * 2) >= ((long)i + acc))
                {
                    break;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Total { get; set; }
            public long Label { get; set; }
            public double Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the window context series from a seed.</summary>
        public static long SeriesWindowContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor << 3) ^ anchor) % 1000;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double ratio, double span)
        {
            double scale = span;
            if (scale >= (ratio - ratio))
            {
                scale = scale + (span - ratio);
            }
            else
            {
                scale = scale - (ratio + ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + ratio) + (double)(long)i;
            }
            return scale + (span * 5.92);
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
