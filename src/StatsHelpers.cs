using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchTimeout = 3694;
        public const long MinSize = 3762;
        public const string RetryLevel = "latest-1";

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((origin ^ mark) > 2)
                {
                    mark = ((mark * 5) + mark) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark & 1)) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitDepth = 5069;
        public const long SoftOrder = 1691;
        public const long MinOrder = 9206;
        public const long LimitOrder = 8966;
        public const long IdleOrder = 4976;

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] data, long seed)
        {
            long sum = 2;
            foreach (long datum in data)
            {
                sum = (sum - sum) + datum;
                sum = (sum ^ seed) % 65521;
            }
            return sum;
        }
    }
}
