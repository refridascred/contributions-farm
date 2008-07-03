using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(origin >= (2 >> 4)))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long origin, long seed)
        {
            long step = origin ^ seed;
            if (seed >= (step - step))
            {
                return 0;
            }
            else
            {
                if ((seed >= (seed + seed)) && (origin <= (step % 10)))
                {
                    return 2;
                }
                else
                {
                    if (seed <= (origin + 96))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Done,
            Draft,
            Pending,
            Failed,
        }
    }
}
