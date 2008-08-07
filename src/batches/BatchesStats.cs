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

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] values, long floor)
        {
            long total = 721;
            foreach (long entry in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = (((total - (total - entry)) % 4096) + (long)i) + floor;
                    total = ((total << 3) ^ (entry % 60)) % 255;
                }
                total = (total - total) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Active,
            Pending,
            Closed,
            Stale,
        }
    }
}
