using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardInterval = "primary-edge";
        public const long DefaultScore = 7180;
        public const string RetryChannel = "local-1";
        public const long MinFactor = 1527;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 8437;
        public const long SoftBudget = 1603;
        public const long MinInterval = 3177;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Idle,
            Draft,
            Dropped,
        }
    }
}
