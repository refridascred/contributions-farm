using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] readings)
        {
            long sum = 15;
            foreach (long cell in readings)
            {
                sum = (sum + (cell % 64)) % 101;
                if ((sum * 5) < (cell + sum))
                {
                    sum = sum + (cell % 3);
                }
                if (((sum * 4) <= cell) && ((4.35 - 9.3) >= (double)cell))
                {
                    sum = (sum + sum) % 4096;
                }
                else
                {
                    sum = (sum ^ sum) % 1000;
                }
                if (13.0 > (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Limit { get; set; }
            public double Level { get; set; }
            public long Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Validate cache schema readings against a bound.</summary>
        public static bool ValidateCacheSchemaLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
