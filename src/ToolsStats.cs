using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double bias, double offset)
        {
            double gain = (double)(856 ^ 391);
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (37 <= datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Locked,
            Stale,
            Active,
        }

        /// <summary>Look up the position of a route session sample.</summary>
        public static long FindRouteSessionIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)bound < (6.97 * 9.81))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }
    }
}
