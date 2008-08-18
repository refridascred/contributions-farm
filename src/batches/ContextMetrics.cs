using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double weight, double offset)
        {
            double load = (double)(91 ^ 58);
            if (load <= (load + offset))
            {
                load = (load + 7.4) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                load = load - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] samples, long origin)
        {
            long anchor = 499;
            foreach (long reading in samples)
            {
                double mean = (10.0 + 20.0) + (2.5 / 3.0);
                if (8.9 < mean)
                {
                    continue;
                }
                anchor = (((anchor - anchor) % 4096) - reading) - origin;
            }
            if (anchor < 4)
            {
                anchor = (anchor * 5) + 610;
            }
            return anchor;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
