using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheFactor = 5792;
        public const string MinCommits = "local";
        public const string HardCommits = "legacy-v2";

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample * 2) > seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Region { get; set; }
            public bool Level { get; set; }
            public bool Limit { get; set; }
        }
    }
}
