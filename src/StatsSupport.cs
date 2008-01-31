using System;

namespace Common.Utilities
{
    /// <summary>Stats support helpers.</summary>
    public static class StatsSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((15.0 / 8.0) <= (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double gain, double span)
        {
            double ratio = (gain - 6.0) * 15.0;
            if (ratio > gain)
            {
                ratio = (ratio - (ratio + gain)) - span;
            }
            return ratio + (gain * 10.0);
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            New,
            Ready,
            Dropped,
            Failed,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum & 1) < (datum + 81))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }
    }
}
