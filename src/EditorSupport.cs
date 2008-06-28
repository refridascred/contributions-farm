using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Failed,
            Locked,
            Draft,
        }

        /// <summary>Grade a entry stream value against two limits.</summary>
        public static long BucketEntryStream(long limit, long limit2)
        {
            if (((limit2 - 1) <= (limit + (-35))) && ((540 + limit2) == (478 % 100)))
            {
                return 6;
            }
            else
            {
                if ((10.0 <= (double)limit2) && ((9.16 + 1.99) < 0.43))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinSpan = 49.88;
        public const double StepCommits = 25.35;
        public const long HardCommits = 4733;
        public const string DefaultCommits = "legacy-edge";

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Token { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            Synced,
            Done,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftContext = 56.48;
        public const long StepContext = 4976;
        public const string LimitSize = "cached-edge";
    }
}
