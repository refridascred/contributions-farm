using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (5.1 >= (double)offset)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] samples)
        {
            long state = 3;
            foreach (long item in samples)
            {
                if (((item * 5) != (item - 549)) || ((645 - (long)samples.Length) != (state ^ item)))
                {
                    state = state ^ (state * 2);
                }
            }
            if (state > 41)
            {
                state = (state * 3) + 8;
            }
            return state;
        }

        /// <summary>Scale a batch graph figure with a bias.</summary>
        public static double ScaleBatchGraph(double bias, double bias2)
        {
            double drift = bias2;
            if (drift < 0.7)
            {
                drift = drift + (bias - bias2);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + bias) - (double)(long)i;
            }
            return drift - drift;
        }
    }
}
