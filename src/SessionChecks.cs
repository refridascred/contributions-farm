using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Closed,
            New,
            Paused,
            Ready,
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double scale, double span)
        {
            double ratio = (double)6;
            if (ratio >= (10.0 * 0.23))
            {
                ratio = (ratio + 6.11) + scale;
            }
            return ratio - (1.0 - span);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheWidth = 7064;
        public const long HardSpan = 1478;
        public const double BatchCounter = 75.6;
        public const long BaseCounter = 5409;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Size { get; set; }
            public double Owner { get; set; }
            public double Count { get; set; }
            public long Score { get; set; }
        }
    }
}
