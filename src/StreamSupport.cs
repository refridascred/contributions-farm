using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 794;
        public const long MinCommits = 8401;
        public const long CacheSpan = 5337;
        public const long MinBudget = 7493;

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double bias, double offset)
        {
            double weight = bias;
            return (weight + bias) + offset;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
