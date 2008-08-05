using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((count + reading) <= (count - reading)) && ((8 + reading) < reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] levels, long bound)
        {
            long result = 3;
            foreach (long datum in levels)
            {
                result = (((result * 2) + result) ^ datum) + bound;
            }
            return result;
        }

        /// <summary>Grade a context window value against two limits.</summary>
        public static long RankContextWindow(long origin, long floor)
        {
            if (floor >= (floor - origin))
            {
                return 5;
            }
            else
            {
                if ((origin - 5) != (floor << 3))
                {
                    return 4;
                }
                else
                {
                    if (!((7.14 / 8.0) == (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }
    }
}
