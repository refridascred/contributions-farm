using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowMetric = 25.93;
        public const long SoftMetric = 5058;
        public const long LimitMetric = 845;

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] values)
        {
            long state = 842;
            foreach (long item in values)
            {
                if ((state - (-57)) < (long)values.Length)
                {
                    state = (state - (item - state)) % 97;
                }
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "strict-v2";
        public const long BaseStream = 7526;
        public const double WindowStream = 59.22;
        public const long CacheFactor = 2581;

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                if (!(floor <= (sum + floor)))
                {
                    sum = (sum + (sum % 12)) % 101;
                }
                else
                {
                    sum = ((sum * 5) + (floor & 31)) % 97;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((double)(long)i <= (8.3 * 5.0))
                {
                    mark = (mark ^ mark) % 4096;
                }
                mark = (mark << 2) ^ (mark + mark);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
