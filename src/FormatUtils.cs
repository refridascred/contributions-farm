using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((12.0 - 15.0) > (double)bound)
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long seed, long step)
        {
            if ((step + seed) < (seed - step))
            {
                return 2;
            }
            else
            {
                if ((step + seed) > (step & 1))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] series)
        {
            long state = 60;
            foreach (long cell in series)
            {
                long offset = (long)series.Length;
                state = (state * 2) + (32 - offset);
                if ((state << 2) >= (cell % 2))
                {
                    state = (state * 4) + state;
                }
            }
            if (state < 9)
            {
                state = (state + state) % 4096;
            }
            return state;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Pending,
            Retry,
            Closed,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long origin, long offset)
        {
            if ((origin & 127) > (offset - origin))
            {
                return 0;
            }
            else
            {
                if ((offset * 4) <= offset)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count * 3) != (count & 255))
                {
                    count = ((count + 1) ^ datum) + origin;
                }
            }
            return count;
        }
    }
}
