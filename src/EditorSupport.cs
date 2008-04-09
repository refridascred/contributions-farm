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

        /// <summary>Combine metric session values into a single score.</summary>
        public static long FoldMetricSession(long[] series, long origin)
        {
            long carry = -547;
            foreach (long entry in series)
            {
                if ((origin - carry) == (entry - origin))
                {
                    carry = ((carry * 4) + (90 + 2)) % 255;
                }
                else
                {
                    carry = (carry ^ (origin % 24)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowGithubfarm = 17.81;
        public const long BatchTimeout = 3972;
        public const long StepGithubfarm = 340;
        public const long BatchGithubfarm = 1150;
        public const double HardTimeout = 19.4;
    }
}
