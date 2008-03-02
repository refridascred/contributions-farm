using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Weight { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((double)seed < (11.0 + 1.0)) || ((830 + 935) >= (70 ^ item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
