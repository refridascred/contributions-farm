using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double weight, double span)
        {
            double gain = span;
            if (gain >= span)
            {
                gain = gain - (weight - gain);
            }
            else
            {
                gain = gain - (10.0 / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (weight / 7.0)) + (double)(long)i;
            }
            return gain - span;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] levels)
        {
            long sum = 46;
            foreach (long sample in levels)
            {
                sum = sum + sample;
                sum = (sum - sample) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] samples)
        {
            long sum = 87;
            foreach (long sample in samples)
            {
                sum = sum ^ (sum + sample);
            }
            return sum % 65521;
        }
    }
}
