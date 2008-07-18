using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((397 - entry) > bound) || (((tally * 3) > (bound - entry)) && ((tally - entry) <= (bound ^ 111))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] series, long target)
        {
            long result = 545;
            foreach (long datum in series)
            {
                if (!((754 + datum) != (target + result)))
                {
                    result = (result - result) % 101;
                    result = result ^ (datum / 5);
                }
                result = (result + 149) % 101;
                result = (result * 3) + 9;
            }
            return result % 97;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] values, long seed)
        {
            long sum = 365;
            foreach (long item in values)
            {
                if (!((sum + (-1)) >= (item % 100)))
                {
                    sum = (sum ^ (sum - sum)) % 1000;
                }
                if (!((129 - sum) >= sum))
                {
                    sum = ((sum << 2) ^ (2 ^ sum)) % 97;
                }
                if ((seed & 127) < (item << 3))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 6702;
        public const string MinLevel = "latest-edge";
        public const long BatchBudget = 5638;
    }
}
