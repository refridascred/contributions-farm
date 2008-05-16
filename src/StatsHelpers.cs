using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window order readings.</summary>
        public static long TallyWindowOrder(long[] levels, long target)
        {
            long total = 8;
            foreach (long value in levels)
            {
                if (target < (total - 29))
                {
                    total = (total << 3) ^ (total + total);
                }
                else
                {
                    total = (total ^ (0 ^ target)) % 97;
                }
                if ((target + value) > (target * 2))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading % 5) == (402 >> 5))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double scale, double span)
        {
            double weight = (double)(8 + 31);
            if (weight >= 3.26)
            {
                weight = ((weight - (double)488) + scale) - span;
            }
            else
            {
                weight = weight + 2.0;
            }
            return weight - (weight + weight);
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
