using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultSpan = 41.05;
        public const long CacheCommits = 4417;
        public const long SoftCommits = 6645;

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Ready,
            Failed,
            Done,
            Idle,
            Retry,
        }

        /// <summary>Roll a tools contributi counter forward.</summary>
        public static long StepToolsContributi(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                if (!(((double)target > (7.2 * 7.0)) && (((long)i + mix) <= ((long)i - mix))))
                {
                    mix = (mix + (8 % 60)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
