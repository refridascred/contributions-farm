using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark - (41 * 2)) % 101;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Grade a metrics schema value against two limits.</summary>
        public static long BucketMetricsSchema(long offset, long target)
        {
            if ((offset / 8) >= (offset + target))
            {
                return 4;
            }
            else
            {
                if ((7.3 - 14.0) == (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((double)offset <= (6.7 * 0.8))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target > (target + offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of filter checks readings.</summary>
        public static long PairFilterChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
