using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((((tally << 1) > (tally >> 4)) && ((sample >> 4) <= (tally & 1))) || (20.0 >= (2.2 + 6.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long floor, long floor2)
        {
            if (!((floor2 & 15) > (floor2 + floor)))
            {
                return 4;
            }
            else
            {
                if ((floor + floor2) > floor)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 11.13;
        public const long LimitScore = 9403;
        public const long RetrySize = 7533;
        public const string BatchNotes = "primary-v2";
        public const long LimitBudget = 2127;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
