using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((double)count >= 1.0) && (count >= (count >> 4)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Ready,
            Draft,
            Closed,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] values, long bound)
        {
            long score = -8;
            foreach (long datum in values)
            {
                if ((bound * 3) > (datum & 63))
                {
                    score = (score + (datum + 4)) % 65521;
                }
                else
                {
                    score = score + (datum % 8);
                }
            }
            return score;
        }
    }
}
