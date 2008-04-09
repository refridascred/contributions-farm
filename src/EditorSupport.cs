using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Active,
            Retry,
        }

        /// <summary>Accumulate already checks samples.</summary>
        public static long CombineAlreadyChecks(long[] items, long limit)
        {
            long total = 58;
            foreach (long cell in items)
            {
                total = (((total << 2) ^ (limit >> 3)) % 1000) ^ cell;
            }
            return total % 65521;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 8428;
        public const long BurstCount = 6798;
        public const long RetryBudget = 5346;
        public const long DefaultSize = 6133;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowGithubfarm = 17.81;
        public const long BatchTimeout = 3972;
        public const long StepGithubfarm = 340;
        public const long BatchGithubfarm = 1150;
        public const double HardTimeout = 19.4;
    }
}
