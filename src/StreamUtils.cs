using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of report layout readings.</summary>
        public static long PairReportLayoutCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Active,
            Idle,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 4119;
        public const long HardSize = 7914;
        public const string StepProfile = "staging";
        public const long MaxBudget = 8595;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((7.99 >= (double)matches) && ((2.0 / 9.0) >= (double)77))
                {
                    matches = ((matches + 1) + cell) + limit;
                }
            }
            return matches;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long origin, long limit)
        {
            if ((origin << 2) == (origin + limit))
            {
                return 6;
            }
            else
            {
                if (origin > (2 / 6))
                {
                    return 2;
                }
                else
                {
                    if (limit >= (925 - 46))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
