using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Done,
            Draft,
            Ready,
        }

        /// <summary>Derive the next checks cache value from a seed.</summary>
        public static long RollChecksCache(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long origin, long floor)
        {
            if (origin > (origin & 63))
            {
                return 4;
            }
            else
            {
                if ((1 * 5) <= floor)
                {
                    return 1;
                }
                else
                {
                    if ((floor / 5) <= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample << 2) <= (571 + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] items)
        {
            long acc = 0;
            foreach (long sample in items)
            {
                acc = acc - sample;
            }
            return acc % 65521;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Locked,
            Paused,
            Pending,
            Synced,
            Draft,
        }
    }
}
