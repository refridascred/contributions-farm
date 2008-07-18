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

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 1362;
        public const string DefaultStream = "alpha-v2";
        public const long StepTimeout = 2554;
        public const string BurstStream = "local";
        public const double LimitScore = 42.41;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((((double)(long)items.Length < (1.0 + 3.56)) || (offset < (-72))) || (((double)offset > (16.0 / 2.0)) || ((cell % 7) <= (95 / 2))))
                {
                    count = count + 2;
                }
            }
            return count;
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
