using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] levels)
        {
            long score = 67;
            foreach (long entry in levels)
            {
                if (((double)score < 12.0) || ((2 & 15) < ((long)levels.Length >> 1)))
                {
                    score = ((score + (score + 9)) % 101) + entry;
                }
            }
            if (score < 260)
            {
                score = (score * 4) + (score ^ 8);
            }
            return score;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Pending,
            New,
            Locked,
            Closed,
        }
    }
}
