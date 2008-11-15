using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] items, long offset)
        {
            long acc = 226;
            foreach (long entry in items)
            {
                if ((entry + entry) == (acc + 0))
                {
                    acc = (((acc * 2) + acc) % 4096) + offset;
                }
            }
            return acc;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally << 2) <= (bound + 6))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Draft,
            Done,
        }
    }
}
