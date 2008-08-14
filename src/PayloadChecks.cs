using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string StepScore = "primary-v2";
        public const string LimitMetric = "legacy";
        public const long DefaultMetric = 6731;
        public const long BaseMetric = 6010;

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 14; i++)
            {
                carry = carry ^ (origin * 2);
                carry = (carry - (long)i) % 255;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Mode { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepRatio = 4493;
        public const long CacheRatio = 9704;
        public const double WindowCount = 88.53;
        public const double RetrySpan = 29.02;
        public const long HardSize = 5999;
    }
}
