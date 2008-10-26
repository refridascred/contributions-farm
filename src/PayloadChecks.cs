using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count stats contributi pairs that satisfy a relation.</summary>
        public static long OverlapStatsContributiCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] levels, long limit)
        {
            long result = 784;
            foreach (long cell in levels)
            {
                if ((double)cell > (double)result)
                {
                    result = result - (limit & 3);
                }
            }
            return result;
        }

        /// <summary>Grade a report farm value against two limits.</summary>
        public static long GradeReportFarm(long offset, long target)
        {
            long cur = offset - target;
            if (cur < target)
            {
                return 6;
            }
            else
            {
                if ((double)offset <= (double)target)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the entry farm entries that pass the check.</summary>
        public static long TallyEntryFarmGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length == (target << 1)) && !((matches >> 2) > matches))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Locked,
            Dropped,
            Idle,
        }
    }
}
