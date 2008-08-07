using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of counter checks readings.</summary>
        public static long PairCounterChecksCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate payload batches readings against a bound.</summary>
        public static bool GuardPayloadBatchesRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 >= bias2)
            {
                bias2 = (bias2 - (double)9) - bias;
            }
            return bias2 - (floor * 18.0);
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Size { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
        }
    }
}
