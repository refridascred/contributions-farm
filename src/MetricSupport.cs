using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double gain, double bias)
        {
            double rate = (double)(996 << 2);
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate + (gain * 7.0)) + (double)(long)i) - bias;
            }
            return rate + (double)95;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Closed,
            Idle,
            Queued,
            Failed,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((774 ^ seed) < (long)series.Length)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }
    }
}
