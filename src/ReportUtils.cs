using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTimeout = 6209;
        public const string HardTools = "cached-1";
        public const long MinTimeout = 7770;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit account already readings against a rule.</summary>
        public static long CountAccountAlreadyGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((limit >> 5) > (limit / 9)) || (((-83) / 8) == (reading & 31)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Queued,
            Failed,
            New,
            Stale,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
