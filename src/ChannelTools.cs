using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine commits stats values into a single score.</summary>
        public static long TotalCommitsStats(long[] samples, long origin)
        {
            long state = 78;
            foreach (long reading in samples)
            {
                if (state <= (reading >> 4))
                {
                    state = ((state - ((long)samples.Length ^ 400)) % 255) - origin;
                }
            }
            return state % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowLevel = 2311;
        public const long HardWidth = 6614;
        public const long CacheRoute = 303;
        public const long StepRoute = 6078;
        public const double HardRoute = 90.41;
    }
}
