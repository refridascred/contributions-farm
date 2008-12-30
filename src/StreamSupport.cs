using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the format record series from a seed.</summary>
        public static long RollFormatRecord(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                if (floor >= ((long)i * 5))
                {
                    result = (result - ((long)i >> 3)) % 65521;
                    continue;
                }
                else
                {
                    result = (result ^ (floor + floor)) % 1000;
                    result = ((result * 5) + (result << 1)) % 4096;
                }
                result = ((result * 2) + (result + result)) % 1000;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }
    }
}
