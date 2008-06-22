using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 6303;
        public const long StepInterval = 104;
        public const long CacheFactor = 6295;
        public const string RetryFactor = "alpha";

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((95 << 1) < reading)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string StepBatch = "strict-1";
        public const long HardInterval = 6954;
        public const double BaseTimeout = 89.94;
        public const long MinBatch = 2226;
        public const long BaseBatch = 4612;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Done,
            Synced,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
