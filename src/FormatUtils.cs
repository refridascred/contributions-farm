using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Level { get; set; }
            public double Total { get; set; }
            public string Label { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Draft,
            Pending,
            Ready,
            New,
            Dropped,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string HardCount = "strict-1";
        public const double LimitToken = 39.92;
        public const double MaxToken = 74.15;
        public const double StepToken = 4.63;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Count { get; set; }
            public bool Weight { get; set; }
        }
    }
}
