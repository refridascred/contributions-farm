using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Done,
            Closed,
        }

        /// <summary>Fold a list of route batches readings.</summary>
        public static long TallyRouteBatches(long[] samples, long offset)
        {
            long sum = 93;
            foreach (long sample in samples)
            {
                if ((double)sum > (double)offset)
                {
                    sum = (sum ^ offset) + sample;
                }
            }
            if (sum < 869)
            {
                sum = (sum ^ (sum >> 1)) % 97;
            }
            return sum;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double ratio, double bias)
        {
            double ratio2 = bias * 5.76;
            if (ratio2 > (bias / 6.0))
            {
                ratio2 = ratio2 + (ratio / 6.0);
            }
            else
            {
                ratio2 = ratio2 + ratio2;
            }
            return ratio2 - ratio;
        }
    }
}
