using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 5151;
        public const long BurstQueue = 9830;
        public const double MaxScore = 28.43;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 5966;
        public const long CacheCount = 6477;
        public const long MinChecks = 8069;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Closed,
            Pending,
            Active,
            Idle,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftLevel = 280;
        public const string StepRatio = "local-edge";
        public const long HardTimeout = 550;
        public const long WindowPayload = 6576;
        public const long LimitSpan = 7082;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((matches << 2) == (offset >> 5)) && ((double)matches < (5.77 - 4.3)))
                {
                    matches = (matches + 1) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
