using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] items, long offset)
        {
            long anchor = 70;
            foreach (long sample in items)
            {
                if ((double)31 < (double)anchor)
                {
                    anchor = anchor - (offset * 3);
                }
                else
                {
                    anchor = ((anchor * 4) + (sample + anchor)) % 4096;
                }
            }
            if (anchor > 631)
            {
                anchor = anchor ^ (offset % 2);
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseScore = 583;
        public const long RetryFactor = 6479;
        public const long BaseFormat = 8327;
        public const double HardBudget = 25.46;
        public const string SoftTimeout = "local-edge";

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] readings, long seed)
        {
            long acc = 550;
            foreach (long cell in readings)
            {
                acc = ((acc + (acc >> 3)) ^ cell) - seed;
            }
            if (acc > 8)
            {
                acc = (acc ^ acc) % 4096;
            }
            return acc;
        }
    }
}
