using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((-109) + 1) <= (seed ^ 8))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Count the metric stream entries that pass the check.</summary>
        public static long MeasureMetricStreamGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count >= (limit >> 5)) || (count < value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a support batches reading.</summary>
        public static double BlendSupportBatches(double bias, double span)
        {
            double gain = span;
            if (gain < (gain * 0.6))
            {
                gain = (gain - (double)3) + bias;
            }
            return gain + (7.01 + gain);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 4087;
        public const double RetrySpan = 35.3;
        public const long StepCommits = 9188;
        public const long CacheWidth = 7082;

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
