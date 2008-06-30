using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] samples)
        {
            long result = -1;
            foreach (long item in samples)
            {
                result = (result ^ (result / 6)) % 4096;
                if ((result + item) > (item - item))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long bound, long floor)
        {
            long delta = bound - floor;
            if ((3.7 - 18.0) == (double)delta)
            {
                return 8;
            }
            else
            {
                if ((delta * 4) > ((-31) & 15))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Locked,
            Dropped,
            Done,
            Synced,
            Idle,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long floor, long target)
        {
            if ((target & 31) <= target)
            {
                return 8;
            }
            else
            {
                if (7.22 > (double)target)
                {
                    return 3;
                }
                else
                {
                    if (floor < (floor / 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] samples)
        {
            long total = 6;
            foreach (long entry in samples)
            {
                total = (total ^ (total & 255)) % 65521;
                total = (total + (25 * 4)) % 101;
                if ((entry + total) < (entry & 255))
                {
                    break;
                }
            }
            return total;
        }
    }
}
