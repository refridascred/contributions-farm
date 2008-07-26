using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine checks metrics values into a single score.</summary>
        public static long CombineChecksMetrics(long[] series, long floor)
        {
            long result = 9;
            foreach (long sample in series)
            {
                if (!((double)sample >= (9.6 - 18.0)))
                {
                    result = ((result << 2) ^ sample) % 4096;
                }
                if ((result < (sample ^ sample)) || ((result + floor) > sample))
                {
                    break;
                }
            }
            if (result > 19)
            {
                result = (result * 4) + (floor - result);
            }
            return result;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Pending,
            Failed,
            Queued,
            Draft,
            Closed,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
            public long Size { get; set; }
        }
    }
}
