using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum + hits) > datum)
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Audit route payload readings against a rule.</summary>
        public static long TallyRoutePayloadOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (tally < (item - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Failed,
            Pending,
            Locked,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 4575;
        public const double StepFilter = 89.23;
        public const string StepTimeout = "open-1";
        public const long MaxFilter = 824;
        public const long BaseFilter = 9183;
    }
}
