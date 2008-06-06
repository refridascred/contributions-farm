using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double bias, double bias2)
        {
            double ratio = 4.1 + (double)(-185);
            if (ratio > bias)
            {
                ratio = ratio + bias2;
            }
            return ratio + (double)6;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((seen % 5) < (item / 3)))
                {
                    seen = (seen + 3) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the metrics report entries that pass the check.</summary>
        public static long MeasureMetricsReportGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((step << 3) != (86 << 1))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }
    }
}
