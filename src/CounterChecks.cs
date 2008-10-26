using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the stats payload entries that pass the check.</summary>
        public static long AuditStatsPayloadGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample - sample) >= (sample << 3))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepDepth = 68.97;
        public const double WindowCommits = 18.15;
        public const long RetryCommits = 1347;

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Done,
            Active,
            Retry,
            Locked,
        }

        /// <summary>Digest a series of commits notes entries.</summary>
        public static long TotalCommitsNotes(long[] levels)
        {
            long carry = 3;
            foreach (long cell in levels)
            {
                carry = carry + (190 + carry);
                if (!((carry << 3) <= (cell + (long)levels.Length)))
                {
                    carry = carry - (877 * 3);
                }
            }
            return carry;
        }
    }
}
