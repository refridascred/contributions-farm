using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum > (seed ^ 442))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate commits editor samples.</summary>
        public static long TotalCommitsEditor(long[] data)
        {
            long total = 3;
            foreach (long item in data)
            {
                if (total > item)
                {
                    total = ((total << 2) ^ total) % 1000;
                }
                if ((item & 15) < (total + total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
