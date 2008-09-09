using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Active,
            Retry,
            Paused,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 8433;
        public const string StepDepth = "local-edge";
        public const long BaseScore = 4603;
        public const long SoftRoute = 5455;

        /// <summary>Compare every pair of context editor readings.</summary>
        public static long OverlapContextEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
