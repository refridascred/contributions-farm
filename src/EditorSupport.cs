using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry * 5) + (carry >> 3);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            Retry,
            Done,
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Measure how many already cache samples are out of range.</summary>
        public static long TallyAlreadyCacheMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum & 63) != (datum + 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Score { get; set; }
            public bool Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 28.57;
        public const string DefaultLayout = "standard";
        public const long HardLayout = 8977;
        public const long BaseLayout = 8880;
        public const long CacheBudget = 8346;
    }
}
