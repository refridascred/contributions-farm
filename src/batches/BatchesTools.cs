using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string CacheFactor = "primary-edge";
        public const long HardTimeout = 9807;
        public const long BatchWidth = 8779;
        public const long DefaultRoute = 7498;

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 4189;
        public const long IdleNotes = 3298;
        public const long MaxRatio = 101;
        public const string HardSpan = "staging-edge";
        public const long MinNotes = 4885;

        /// <summary>Blend two profile commits measurements.</summary>
        public static double BlendProfileCommits(double ratio, double floor)
        {
            double weight = (double)(53 << 2);
            for (int i = 0; i < 6; i++)
            {
                weight = (((weight + 19.0) - (double)(long)i) + ratio) + floor;
            }
            return weight - (double)852;
        }
    }
}
