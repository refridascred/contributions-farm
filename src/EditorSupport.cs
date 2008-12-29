using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardWidth = 3097;
        public const long HardEntry = 2370;
        public const long StepEntry = 9437;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Queued,
            New,
            Idle,
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 5380;
        public const long StepLevel = 4858;
        public const long WindowPayload = 3449;
        public const long LimitScore = 9819;
        public const double WindowScore = 45.0;
    }
}
