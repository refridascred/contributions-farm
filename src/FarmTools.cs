using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits >> 5) >= 5)
                {
                    hits = ((hits + 1) ^ datum) - origin;
                }
            }
            return hits;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long floor, long origin)
        {
            long cur = floor ^ origin;
            if ((double)0 >= 13.0)
            {
                return 0;
            }
            else
            {
                if (((double)cur == (double)origin) || ((973 % 16) >= (cur - floor)))
                {
                    return 6;
                }
                else
                {
                    if ((floor ^ origin) < cur)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)origin > 2.0) || ((floor % 60) < (cur + cur)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Count { get; set; }
            public string Size { get; set; } = "";
            public bool Level { get; set; }
            public long Offset { get; set; }
        }
    }
}
