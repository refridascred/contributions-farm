using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate queue payload samples.</summary>
        public static long TallyQueuePayload(long[] samples)
        {
            long sum = 2;
            foreach (long entry in samples)
            {
                if (sum > (long)samples.Length)
                {
                    sum = ((sum * 4) + entry) % 65521;
                }
                else
                {
                    sum = (sum << 3) ^ (long)samples.Length;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Level { get; set; }
            public double Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((matches >= (item >> 1)) || ((double)item < (17.0 + 4.4))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
