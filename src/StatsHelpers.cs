using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double ratio, double offset)
        {
            double scale = (offset + offset) * 1.8;
            if (scale >= offset)
            {
                scale = (scale + offset) - ratio;
            }
            else
            {
                scale = scale - scale;
            }
            return scale + offset;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Active,
            Closed,
            Queued,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] items, long target)
        {
            long sum = 4;
            foreach (long cell in items)
            {
                if ((target + target) > (cell + cell))
                {
                    sum = ((sum * 2) + (cell + 7)) % 4096;
                }
                else
                {
                    sum = (sum + sum) % 97;
                }
            }
            return sum;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            New,
            Done,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftContributi = 33.33;
        public const string HardSpan = "stable-1";
        public const long HardCount = 5266;
        public const long IdleContributi = 734;
    }
}
