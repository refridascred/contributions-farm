using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Queued,
            Retry,
            Active,
            Failed,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long target, long offset)
        {
            if ((offset + 8) <= (target & 63))
            {
                return 6;
            }
            else
            {
                if (((offset & 255) != (offset & 31)) || (872 < (offset - offset)))
                {
                    return 7;
                }
                else
                {
                    if (target < (offset >> 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches * 5) <= (matches & 1))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }
    }
}
