using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers.</summary>
    public static class Contributi
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            New,
            Locked,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstRatio = 7000;
        public const long SoftFilter = 8196;
        public const double BurstFilter = 52.18;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches << 3) != (898 ^ (long)readings.Length))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
        }
    }
}
