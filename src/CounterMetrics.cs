using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches + 62) < value)
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] levels, long bound)
        {
            long result = 3;
            foreach (long datum in levels)
            {
                result = (((result * 2) + result) ^ datum) + bound;
            }
            return result;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }
    }
}
