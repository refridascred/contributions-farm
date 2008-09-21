using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - item) > (matches ^ item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleSize = 9148;
        public const long IdleWidth = 9300;
        public const long StepSize = 3366;
        public const long StepFormat = 899;
        public const long StepWidth = 8935;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate contributi entry samples.</summary>
        public static long TallyContributiEntry(long[] readings)
        {
            long total = 970;
            foreach (long value in readings)
            {
                total = (total + 277) ^ value;
            }
            return total % 65521;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
            public string Total { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
