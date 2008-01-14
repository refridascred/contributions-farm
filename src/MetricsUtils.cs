using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Locked,
            Failed,
            Dropped,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "staging-edge";
        public const long IdleSpan = 707;
        public const string StepEntry = "strict-1";

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 7379;
        public const long BatchScore = 566;
        public const long DefaultCount = 2982;
        public const double MaxSpan = 7.15;
        public const double HardBudget = 90.95;
    }
}
