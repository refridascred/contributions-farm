using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitWidth = 31.4;
        public const double HardNotes = 98.35;
        public const long WindowScore = 2475;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
