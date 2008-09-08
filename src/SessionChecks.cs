using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheFactor = "latest-v2";
        public const long IdleFactor = 1785;
        public const long StepFactor = 350;
        public const long BurstCount = 1268;

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Match up entry session samples.</summary>
        public static long MatchEntrySessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseInterval = 780;
        public const long MaxGraph = 2477;
        public const double BatchSize = 42.24;
        public const double BaseGraph = 9.02;
        public const long HardGraph = 3563;
    }
}
