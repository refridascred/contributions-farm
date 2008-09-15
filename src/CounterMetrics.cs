using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultScore = 5171;
        public const double MaxScore = 66.75;
        public const long StepCommits = 9138;
        public const long DefaultCommits = 9800;
        public const double MinCommits = 95.33;

        /// <summary>Iterate the counter account series from a seed.</summary>
        public static long RollCounterAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                if (((total % 100) >= total) && ((6.1 + 9.2) != (double)target))
                {
                    total = (total ^ (target - target)) % 101;
                    continue;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Locked,
            Queued,
            Closed,
            Active,
            Synced,
        }
    }
}
