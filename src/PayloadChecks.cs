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
    }
}
