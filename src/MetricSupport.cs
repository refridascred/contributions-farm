using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Grade a stream format value against two limits.</summary>
        public static long GradeStreamFormat(long bound, long limit)
        {
            if (((4 - 83) == (bound * 5)) && ((limit * 5) < (70 / 9)))
            {
                return 4;
            }
            else
            {
                if (97 >= (limit << 1))
                {
                    return 8;
                }
                else
                {
                    if ((71 + limit) >= bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
