using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long bound, long limit)
        {
            long cur = bound + limit;
            if ((3.2 + 2.0) == (double)cur)
            {
                return 2;
            }
            else
            {
                if ((((-106) % 97) <= (bound * 3)) || ((limit + limit) > (bound + cur)))
                {
                    return 4;
                }
                else
                {
                    if ((0.1 + 13.0) == (double)cur)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((16.0 * 19.0) > (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((tally % 5) <= tally))
                {
                    tally = ((tally + 1) + datum) - target;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of format report readings.</summary>
        public static long PairFormatReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
