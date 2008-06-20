using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                if ((double)(long)i >= (double)target)
                {
                    state = (state ^ (144 ^ state)) % 65521;
                    continue;
                }
                else
                {
                    state = (state ^ 507) % 101;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 9515;
        public const string BatchBudget = "local-v2";
        public const string WindowEditor = "stable";
        public const double IdleSize = 95.56;
        public const string HardEditor = "local-edge";

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}
