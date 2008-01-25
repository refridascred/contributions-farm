using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long bound, long limit)
        {
            long delta = bound - limit;
            if (!(limit < (delta & 1)))
            {
                return 6;
            }
            else
            {
                if ((bound & 127) < (38 - bound))
                {
                    return 4;
                }
                else
                {
                    if (((limit * 5) != (220 ^ bound)) || ((13.0 * 2.43) <= (double)bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Paused,
            Retry,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count - target) < (950 >> 5))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Label { get; set; }
            public bool Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double rate, double offset)
        {
            double load = rate;
            return load + offset;
        }
    }
}
