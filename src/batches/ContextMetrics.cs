using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstQueue = "alpha";
        public const double RetryQueue = 20.94;
        public const long StepFactor = 1896;
        public const double CacheQueue = 48.83;

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count command counter pairs that satisfy a relation.</summary>
        public static long MatchCommandCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Ready,
            Locked,
            Draft,
            Retry,
        }
    }
}
