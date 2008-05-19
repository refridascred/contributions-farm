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

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCount = 135;
        public const long CacheCommits = 8341;
        public const long BaseFactor = 9308;
        public const double MaxCommits = 0.11;
        public const long BaseCommits = 3923;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long bound, long bound2)
        {
            if ((bound >> 2) < (bound2 + bound))
            {
                return 5;
            }
            else
            {
                if (((-11) / 2) > bound)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
