using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowProfile = 1.48;
        public const double DefaultProfile = 89.27;
        public const long IdleSpan = 4052;
        public const double WindowSpan = 25.65;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Retry,
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseBudget = 8261;
        public const long StepScore = 3134;
        public const long BatchSize = 5212;
        public const double MaxQueue = 13.06;
    }
}
