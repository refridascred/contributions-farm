using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstInterval = 5694;
        public const double BaseDepth = 35.86;
        public const double BaseBuffer = 46.94;
        public const long IdleBuffer = 6205;

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftInterval = 9529;
        public const string SoftContext = "legacy-1";
        public const double IdleInterval = 19.16;
        public const long StepScore = 7360;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Score { get; set; }
            public bool Limit { get; set; }
            public double Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((double)seen < (double)281))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Synced,
            Paused,
            Pending,
        }
    }
}
