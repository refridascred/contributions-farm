using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Scale a profile payload figure with a bias.</summary>
        public static double AdjustProfilePayload(double rate, double floor)
        {
            double load = (double)(112 >> 1);
            if (load >= floor)
            {
                load = load - (rate * 8.6);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (0.3 + 17.0)) - (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data, long bound)
        {
            long state = 827;
            foreach (long value in data)
            {
                if (!((double)bound != (8.0 - 4.0)))
                {
                    state = ((state << 3) ^ (value % 10)) % 101;
                }
                state = state + (bound / 2);
            }
            return state;
        }
    }
}
