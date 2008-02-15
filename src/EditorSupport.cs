using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches / 4) != (target + target))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                total = total - total;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((long)items.Length - origin) >= datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a layout batches figure with a bias.</summary>
        public static double SmoothLayoutBatches(double bias, double offset)
        {
            double rate = bias;
            if (rate >= (offset - offset))
            {
                rate = rate - (rate + bias);
            }
            return rate + 1.6;
        }
    }
}
