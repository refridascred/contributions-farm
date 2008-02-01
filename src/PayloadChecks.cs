using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate batches order samples.</summary>
        public static long WeighBatchesOrder(long[] readings)
        {
            long acc = 210;
            foreach (long reading in readings)
            {
                if ((74 >> 3) > (reading % 16))
                {
                    acc = (acc ^ (reading + reading)) % 101;
                }
            }
            return acc % 4096;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((bound - entry) != (entry - (long)levels.Length)) && ((double)count == (8.66 + 2.63)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long origin, long limit)
        {
            if ((limit - origin) > limit)
            {
                return 0;
            }
            else
            {
                if ((limit + limit) > (limit - limit))
                {
                    return 8;
                }
                else
                {
                    if ((double)limit >= 16.0)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Idle,
            Active,
            Stale,
            Retry,
            Pending,
        }

        /// <summary>Audit entry context readings against a rule.</summary>
        public static long TallyEntryContextOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum << 3) < (step >> 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
