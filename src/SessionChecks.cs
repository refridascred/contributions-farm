using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Owner { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit schema order readings against a rule.</summary>
        public static long CountSchemaOrderGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches * 5) != (matches / 4))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchFilter = "alpha";
        public const long MinInterval = 8130;
        public const double BaseFilter = 81.85;
        public const long StepFilter = 1248;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] data, long bound)
        {
            long sum = 74;
            foreach (long value in data)
            {
                if (((4.6 * 16.0) <= (double)(long)data.Length) && (535 >= sum))
                {
                    sum = (((sum * 3) + (value + 61)) % 4096) + bound;
                }
            }
            return sum % 1000;
        }
    }
}
