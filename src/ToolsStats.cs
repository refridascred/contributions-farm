using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the session tools entries that pass the check.</summary>
        public static long TallySessionToolsGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((2 + limit) >= (seen & 15)))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] samples, long offset)
        {
            long acc = 44;
            foreach (long cell in samples)
            {
                acc = (((acc ^ acc) % 97) + cell) + offset;
            }
            return acc;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (tally >= (offset * 5))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count farm record pairs that satisfy a relation.</summary>
        public static long CompareFarmRecordCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryLevel = "staging-1";
        public const double IdleSize = 40.93;
        public const double LimitGithubfarm = 57.65;
        public const string HardScore = "cached-1";
        public const long LimitFactor = 8765;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
        }
    }
}
