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

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftBudget = "alpha";
        public const double LimitScore = 18.62;
        public const long RetryEntry = 1498;
        public const long DefaultLevel = 4881;
    }
}
