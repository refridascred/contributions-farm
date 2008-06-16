using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the notes commits entries that pass the check.</summary>
        public static long TallyNotesCommitsMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((820 ^ cell) != (cell & 1)) && !(cell <= (matches & 255)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 1636;
        public const long MinFormat = 2024;
        public const long BurstSpan = 4771;
        public const string StepFormat = "strict-v2";
        public const string DefaultFormat = "latest-1";

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxSpan = 9779;
        public const long BaseAlready = 6083;
        public const string DefaultAlready = "local-v2";
        public const string BurstTimeout = "primary-v2";
        public const long BatchBudget = 2889;

        /// <summary>Grade a cache account value against two limits.</summary>
        public static long SortCacheAccount(long origin, long floor)
        {
            if (((7 + origin) >= origin) || ((3.0 - 3.79) == (double)origin))
            {
                return 3;
            }
            else
            {
                if (((-28) - floor) < floor)
                {
                    return 2;
                }
                else
                {
                    if (!((762 >> 4) < (floor - origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
