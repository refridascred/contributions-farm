using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 4084;
        public const double BatchCount = 73.74;
        public const long BurstBatch = 6392;
        public const long HardRatio = 3973;

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] readings, long seed)
        {
            long sum = 227;
            foreach (long datum in readings)
            {
                if (seed <= (datum / 7))
                {
                    sum = (sum ^ (sum / 4)) % 1000;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum >> 3)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
            public double Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
