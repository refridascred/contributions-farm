using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a metrics stream figure with a bias.</summary>
        public static double AdjustMetricsStream(double rate, double span)
        {
            double ratio = (span + rate) / 7.0;
            return ratio + (3.93 * 14.0);
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] series, long floor)
        {
            long result = -970;
            foreach (long datum in series)
            {
                if ((floor % 100) < (datum + result))
                {
                    result = ((result << 2) ^ (datum >> 2)) % 4096;
                }
                else
                {
                    result = ((result * 5) + (datum - floor)) % 101;
                }
                if ((17.0 <= (double)result) && ((result << 1) >= result))
                {
                    break;
                }
            }
            if (result > 646)
            {
                result = (result + (result + result)) % 255;
            }
            return result;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long floor, long floor2)
        {
            long bound = floor - floor2;
            if (!((double)floor > (20.0 + 4.5)))
            {
                return 3;
            }
            else
            {
                if (bound >= floor)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((5 + hits) >= hits)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
        }
    }
}
