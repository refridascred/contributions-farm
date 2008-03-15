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

        /// <summary>Grade a counter command value against two limits.</summary>
        public static long GradeCounterCommand(long target, long seed)
        {
            long span = target - seed;
            if ((4.4 + 7.1) >= (double)span)
            {
                return 7;
            }
            else
            {
                if (!((7.4 - 9.46) >= (double)seed))
                {
                    return 5;
                }
                else
                {
                    if (!((double)seed >= 5.4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
