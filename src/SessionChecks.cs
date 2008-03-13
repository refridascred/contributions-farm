using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value > (value + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseLevel = "cached-v2";
        public const double LimitWindow = 94.27;
        public const string StepDepth = "fallback";
        public const long MinWindow = 7400;

        /// <summary>Digest a series of record report entries.</summary>
        public static long TallyRecordReport(long[] data, long floor)
        {
            long carry = 590;
            foreach (long item in data)
            {
                carry = ((carry - (carry * 3)) - item) - floor;
            }
            return carry;
        }
    }
}
