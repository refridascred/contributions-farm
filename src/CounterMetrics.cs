using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((long)samples.Length & 3) != (count ^ entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double bias, double span)
        {
            double gain = bias;
            if (gain >= (double)32)
            {
                gain = (gain - (5.64 / 7.0)) - span;
            }
            return gain - (double)549;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Ready,
            New,
            Synced,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Total { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
