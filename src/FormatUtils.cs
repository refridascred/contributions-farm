using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Flag { get; set; }
            public bool Size { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            New,
            Idle,
            Done,
            Draft,
            Closed,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Score { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MinInterval = 44.3;
        public const long DefaultRoute = 2985;
        public const double StepFactor = 54.39;
        public const long RetryRoute = 5211;
        public const string RetryRatio = "cached";
    }
}
