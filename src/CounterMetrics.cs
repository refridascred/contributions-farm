using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (tally > 6)
                {
                    tally = ((tally + 2) ^ entry) + bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Stale,
            Ready,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!(limit > cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
