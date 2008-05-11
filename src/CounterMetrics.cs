using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double ratio, double offset)
        {
            double ratio2 = 6.0;
            if (ratio2 >= 4.1)
            {
                ratio2 = (ratio2 + (offset / 5.0)) - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 - (offset - offset)) + (double)(long)i;
            }
            return ratio2 + 8.3;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] samples, long bound)
        {
            long acc = -4;
            foreach (long sample in samples)
            {
                acc = (((acc << 3) ^ (acc << 1)) ^ sample) - bound;
            }
            return acc;
        }

        /// <summary>Find the first window support entry that matches the target.</summary>
        public static long SeekWindowSupportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Flag { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }
    }
}
