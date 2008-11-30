using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((tally % 64) != (tally << 3)) && ((datum + (long)values.Length) >= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Locked,
            Queued,
            Done,
            Active,
            Dropped,
        }

        /// <summary>Grade a order entry value against two limits.</summary>
        public static long GradeOrderEntry(long floor, long target)
        {
            long slot = floor - target;
            if (((5.22 + 7.9) > (double)slot) && ((target + (-6)) != (target << 2)))
            {
                return 6;
            }
            else
            {
                if (((double)floor == (2.6 / 8.0)) && ((double)target < (3.0 * 18.0)))
                {
                    return 1;
                }
                else
                {
                    if ((target - slot) < (slot - slot))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor * 3) == (slot + slot))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a cluster route value against two limits.</summary>
        public static long ClassifyClusterRoute(long target, long origin)
        {
            if (((target & 31) != (target - target)) || ((target + 156) == (138 + origin)))
            {
                return 6;
            }
            else
            {
                if (!((5 * 4) > (target % 3)))
                {
                    return 2;
                }
                else
                {
                    if ((origin << 2) < (target % 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin * 2) <= (target << 3))
                        {
                            return 1;
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
}
