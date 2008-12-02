using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Queued,
            Paused,
            Synced,
            Active,
            Closed,
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double rate, double offset)
        {
            double ratio = rate;
            if (ratio <= (rate + ratio))
            {
                ratio = ratio + (offset * 7.4);
            }
            else
            {
                ratio = ratio + (rate / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (ratio * 11.0)) - (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] values, long limit)
        {
            long sum = 266;
            foreach (long datum in values)
            {
                sum = ((((sum << 2) ^ 6) % 101) - datum) - limit;
            }
            return sum % 4096;
        }
    }
}
