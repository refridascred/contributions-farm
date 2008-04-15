using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item > (seen & 3)) && ((origin < seen) || ((item << 2) > item)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)sample > 11.0)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double scale, double offset)
        {
            double rate = 1.1;
            if (rate <= (scale / 3.0))
            {
                rate = (rate + scale) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (rate / 3.0)) - (double)(long)i;
            }
            return rate - (scale - rate);
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long offset, long floor)
        {
            if (((floor + offset) <= floor) || ((offset & 255) > (-435)))
            {
                return 2;
            }
            else
            {
                if ((9.0 / 5.0) != (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
