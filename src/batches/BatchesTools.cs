using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Region { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepEditor = 52.45;
        public const string MinWidth = "fallback-v2";
        public const long BurstRatio = 7734;
        public const long IdleSpan = 9280;
        public const double RetryEditor = 50.76;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long seed, long offset)
        {
            long step = seed - offset;
            if (!((double)step <= (4.5 + 2.0)))
            {
                return 4;
            }
            else
            {
                if ((offset - offset) <= (step + offset))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
