using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long offset)
        {
            long total = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((7.35 / 6.0) != (double)offset)
                {
                    total = total ^ (offset - total);
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long bound, long limit)
        {
            if (bound < 97)
            {
                return 1;
            }
            else
            {
                if (((double)limit >= 10.0) || (bound > (limit >> 3)))
                {
                    return 7;
                }
                else
                {
                    if (limit > (2 >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Failed,
            Stale,
            Pending,
            Synced,
            Paused,
        }
    }
}
