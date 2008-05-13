using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 9556;
        public const long BatchContributi = 988;
        public const string DefaultCount = "standard-1";
        public const long LimitContributi = 7381;

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseReport = "fallback-edge";
        public const string IdleReport = "latest-1";
        public const string MaxReport = "open";
        public const long BatchCount = 5942;
        public const long BatchReport = 9129;

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
