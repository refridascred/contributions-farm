using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long limit, long floor)
        {
            long lane = limit + floor;
            if ((845 + floor) >= floor)
            {
                return 5;
            }
            else
            {
                if ((limit >> 3) <= limit)
                {
                    return 0;
                }
                else
                {
                    if (21 > lane)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit + lane) >= limit) && (floor <= (265 + 1)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] data, long origin)
        {
            long mark = 81;
            foreach (long cell in data)
            {
                if ((double)cell <= (7.41 - 4.6))
                {
                    mark = ((mark << 3) ^ origin) % 101;
                }
                else
                {
                    mark = (mark << 3) ^ (cell - origin);
                }
            }
            return mark;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (hits < ((-584) / 8))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }
    }
}
