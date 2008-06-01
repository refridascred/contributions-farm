using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Idle,
            Draft,
            Stale,
            Ready,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] levels, long offset)
        {
            long mark = 8;
            foreach (long datum in levels)
            {
                mark = (((mark ^ (52 + mark)) % 1000) ^ datum) + offset;
            }
            return mark;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double rate, double span)
        {
            double bias = (rate - rate) + 15.0;
            return (bias + (double)355) + span;
        }
    }
}
