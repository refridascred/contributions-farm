using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 6811;
        public const long LimitRatio = 9661;
        public const double BaseLevel = 74.66;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) <= (count - sample))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            Failed,
            Active,
        }
    }
}
