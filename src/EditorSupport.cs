using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double ratio, double offset)
        {
            double load = ratio;
            return (load - (load * 9.37)) + offset;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen * 4) != (seen + seen))
                {
                    seen = ((seen + 2) + datum) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Count { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a commits metrics value against two limits.</summary>
        public static long SortCommitsMetrics(long origin, long seed)
        {
            if (origin >= ((-1) ^ seed))
            {
                return 1;
            }
            else
            {
                if ((origin ^ seed) < origin)
                {
                    return 4;
                }
                else
                {
                    if ((origin / 6) <= (seed % 100))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
