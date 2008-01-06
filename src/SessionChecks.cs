using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Owner { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit schema order readings against a rule.</summary>
        public static long CountSchemaOrderGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches * 5) != (matches / 4))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchFilter = "alpha";
        public const long MinInterval = 8130;
        public const double BaseFilter = 81.85;
        public const long StepFilter = 1248;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            New,
            Ready,
            Idle,
        }
    }
}
