using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Done,
            Pending,
            Paused,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Limit { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Done,
            Draft,
            Retry,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 1267;
        public const long BatchLevel = 2130;
        public const long StepSession = 5674;

        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheFilter = "standard-1";
        public const double DefaultFilter = 30.58;
        public const long MinFilter = 6446;
    }
}
