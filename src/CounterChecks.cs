using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitLevel = 2.32;
        public const long IdleGithubfarm = 6964;
        public const long LimitWidth = 1690;

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 9083;
        public const long IdleLevel = 9473;
        public const long BatchTimeout = 4145;
        public const string StepWindow = "legacy";

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 8508;
        public const double BatchLayout = 8.63;
        public const string DefaultLayout = "local-1";

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!((10 + offset) > (offset % 7)))
                {
                    sum = sum + (842 + (-44));
                    break;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Rank { get; set; }
            public bool Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Idle,
            Retry,
            Active,
            Stale,
            Queued,
        }
    }
}
