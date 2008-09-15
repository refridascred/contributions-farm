using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many batch context samples are out of range.</summary>
        public static long TallyBatchContextHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits + hits) > (hits ^ target))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((681 + limit) != (item & 63))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate metric token readings against a bound.</summary>
        public static bool GuardMetricTokenRange(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double gain, double offset)
        {
            double drift = gain;
            if (drift <= drift)
            {
                drift = (drift - (drift * 6.0)) + offset;
            }
            else
            {
                drift = drift + (gain / 3.0);
            }
            return drift + (double)64;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheSize = 1348;
        public const string StepBatches = "latest-1";
        public const double MinBatches = 34.06;
        public const string BurstInterval = "open-1";
    }
}
