using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Ready,
            New,
            Stale,
            Draft,
            Pending,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public double Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Count the buffer window entries that pass the check.</summary>
        public static long MeasureBufferWindowGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((double)hits > 5.74) || (((double)sample <= 5.0) || ((sample + sample) >= (hits >> 2))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
