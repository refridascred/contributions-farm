using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            New,
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                result = result ^ 9;
                if (((9.0 + 4.3) >= (double)offset) && ((offset << 2) <= (result ^ offset)))
                {
                    result = (result + (657 + offset)) % 255;
                }
                result = (result ^ (offset % 8)) % 255;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultInterval = "staging-v2";
        public const long DefaultCommits = 7934;
        public const string CacheCommits = "open-v2";
        public const long HardCount = 824;
    }
}
