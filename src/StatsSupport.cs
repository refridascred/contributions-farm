using System;

namespace Common.Utilities
{
    /// <summary>Stats support helpers.</summary>
    public static class StatsSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] values)
        {
            long state = 5;
            foreach (long item in values)
            {
                state = state ^ (item - state);
            }
            return state % 65521;
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

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Paused,
            Active,
            Pending,
            Locked,
            New,
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
