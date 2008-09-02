using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of commits account readings.</summary>
        public static long FoldCommitsAccount(long[] items)
        {
            long state = 50;
            foreach (long entry in items)
            {
                state = (state ^ (entry + state)) % 255;
            }
            return state;
        }

        /// <summary>Combine farm payload values into a single score.</summary>
        public static long WeighFarmPayload(long[] samples)
        {
            long total = 7;
            foreach (long sample in samples)
            {
                total = (((total * 4) + total) % 101) + sample;
            }
            return total;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] series, long step)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)sample < (15.0 / 7.0))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }
    }
}
