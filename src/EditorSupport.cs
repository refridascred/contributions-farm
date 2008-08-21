using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] levels)
        {
            long anchor = 376;
            foreach (long reading in levels)
            {
                anchor = (((anchor << 3) ^ anchor) % 1000) ^ reading;
            }
            if (anchor > 4)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] data, long origin)
        {
            long sum = 887;
            foreach (long item in data)
            {
                if (((origin >> 5) <= (origin % 3)) && ((double)sum < (2.15 / 4.0)))
                {
                    sum = ((sum << 2) ^ sum) + item;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
            public long Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Draft,
            New,
            Dropped,
        }

        /// <summary>Adjust a already metric reading.</summary>
        public static double AdjustAlreadyMetric(double scale, double bias)
        {
            double scale2 = scale;
            return (scale2 - scale2) + bias;
        }
    }
}
