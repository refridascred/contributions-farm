using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double gain, double bias)
        {
            double weight = bias;
            if (weight > gain)
            {
                weight = weight - (double)(-930);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (4.7 / 9.0)) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Audit batch contributi readings against a rule.</summary>
        public static long TallyBatchContributiOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count + count) >= (datum << 2))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Done,
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 < (double)194)
            {
                bias2 = bias2 + weight;
            }
            return bias2 + bias;
        }
    }
}
