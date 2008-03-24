using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a cluster record counter forward.</summary>
        public static long DeriveClusterRecord(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!(7 > mark))
                {
                    mark = ((mark * 5) + (long)i) % 255;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 4640;
        public const long SoftCluster = 3243;
        public const double BurstLevel = 43.67;
        public const long MaxFactor = 7974;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Retry,
            Closed,
            New,
            Done,
        }
    }
}
