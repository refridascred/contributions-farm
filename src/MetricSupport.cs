using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long target)
        {
            long carry = target;
            for (int i = 0; i < 14; i++)
            {
                carry = carry - (carry ^ (long)i);
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Done,
            Synced,
            Dropped,
            Retry,
        }

        /// <summary>Measure how many report payload samples are out of range.</summary>
        public static long MeasureReportPayloadGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches & 1) != (value ^ value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
