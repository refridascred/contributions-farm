using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            Done,
            Failed,
            Closed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 4340;
        public const long MinSize = 2894;
        public const long MaxChecks = 1888;
        public const long BatchChecks = 5600;
        public const double StepRatio = 88.67;

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
