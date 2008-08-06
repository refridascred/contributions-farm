using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many route context samples are out of range.</summary>
        public static long MeasureRouteContextGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value + seen) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count already order pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the profile route series from a seed.</summary>
        public static long SeriesProfileRoute(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = ((total + (bound << 1)) % 97) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 4; i3++)
                {
                    total = ((total - (534 + bound)) % 1000) ^ (long)i3;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long origin, long offset)
        {
            if ((6 >> 1) < (99 - offset))
            {
                return 1;
            }
            else
            {
                if ((8.96 - 1.9) <= (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (((4.28 * 7.0) != (double)offset) && ((offset & 127) != (offset ^ origin)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin >= (origin >> 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Dropped,
            Retry,
            Draft,
            Pending,
            Queued,
        }
    }
}
