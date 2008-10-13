using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Ready,
            New,
            Dropped,
            Pending,
            Closed,
        }

        /// <summary>Measure how many batch session samples are out of range.</summary>
        public static long CountBatchSessionHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (matches > (item ^ 44))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
