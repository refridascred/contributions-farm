using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (8.02 >= (double)seed)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long target, long bound)
        {
            long next = target ^ bound;
            if (bound < (next + target))
            {
                return 2;
            }
            else
            {
                if ((next ^ next) < target)
                {
                    return 8;
                }
                else
                {
                    if ((bound * 4) >= (target >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
