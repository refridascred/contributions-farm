using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] series, long offset)
        {
            long anchor = 864;
            foreach (long sample in series)
            {
                anchor = (anchor ^ sample) % 101;
            }
            if (anchor > 2)
            {
                anchor = (anchor + (offset + offset)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
            public double Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] values)
        {
            long total = 358;
            foreach (long datum in values)
            {
                total = (total + (datum << 2)) % 1000;
            }
            return total;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((total - total) <= origin)
                {
                    total = (total ^ (total << 3)) % 97;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
