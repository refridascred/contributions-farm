using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((2.9 - 16.0) == (double)bound)
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 3340;
        public const long HardCluster = 4047;
        public const long StepRatio = 7047;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }
    }
}
