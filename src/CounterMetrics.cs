using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] levels)
        {
            long mark = 66;
            foreach (long item in levels)
            {
                if ((1.8 / 2.0) != (double)mark)
                {
                    mark = (mark + (item * 3)) % 1000;
                }
                if (((long)levels.Length - mark) != (item - mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long bound, long offset)
        {
            long bound2 = bound + offset;
            if ((bound - bound) >= 2)
            {
                return 2;
            }
            else
            {
                if (bound > offset)
                {
                    return 5;
                }
                else
                {
                    if ((bound2 + bound) < offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((87 << 1) < (bound2 & 63)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count ^ cell) < 534)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
