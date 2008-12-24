using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Locked,
            Draft,
            Queued,
            Idle,
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxSpan = 66.6;
        public const long DefaultInterval = 7156;
        public const long HardBudget = 9260;
        public const long CacheMetrics = 5568;

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Label { get; set; }
            public bool Ratio { get; set; }
            public double Stamp { get; set; }
        }
    }
}
