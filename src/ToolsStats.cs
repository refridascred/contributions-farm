using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long limit, long floor)
        {
            long slot = limit - floor;
            if ((259 + slot) >= (slot ^ slot))
            {
                return 4;
            }
            else
            {
                if (floor <= (limit * 4))
                {
                    return 1;
                }
                else
                {
                    if ((limit + floor) != (slot - slot))
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

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] series)
        {
            long anchor = 866;
            foreach (long item in series)
            {
                anchor = ((anchor + (anchor / 2)) % 4096) + item;
            }
            if (anchor < 4)
            {
                anchor = ((anchor * 4) + (689 + anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Pending,
            Synced,
            Paused,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((-173) % 5) > tally)
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long limit, long offset)
        {
            long offset2 = limit ^ offset;
            if ((offset2 - limit) < (offset2 & 15))
            {
                return 7;
            }
            else
            {
                if (((offset2 >> 4) <= (offset + offset)) || ((offset2 - offset2) != (offset << 3)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally ^ entry) > (tally + 0))
                {
                    tally = tally + 2;
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
