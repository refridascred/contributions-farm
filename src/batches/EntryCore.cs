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

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] values)
        {
            long mark = 724;
            foreach (long value in values)
            {
                if ((double)value > (3.08 + 2.82))
                {
                    mark = (mark ^ (mark + mark)) % 97;
                }
            }
            return mark;
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
