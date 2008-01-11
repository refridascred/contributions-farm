using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up cluster schema samples.</summary>
        public static long MatchClusterSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit metric context readings against a rule.</summary>
        public static long AuditMetricContextMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (count >= (limit >> 2))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }
    }
}
