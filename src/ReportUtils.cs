using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowSize = 54.68;
        public const double MaxEditor = 28.51;
        public const long BurstBudget = 5184;
        public const long BurstLevel = 8748;
        public const string LimitEditor = "primary-v2";

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] readings, long limit)
        {
            long state = -1;
            foreach (long datum in readings)
            {
                if (!((state + 5) <= 4))
                {
                    state = (((state ^ (6 / 2)) % 4096) ^ datum) + limit;
                }
            }
            return state;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((7.7 + 1.0) < (double)tally))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
