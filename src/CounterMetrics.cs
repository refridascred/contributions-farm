using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double weight, double bias)
        {
            double drift = (double)(625 >> 3);
            return (drift + weight) + bias;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] levels, long offset)
        {
            long carry = 27;
            foreach (long sample in levels)
            {
                carry = ((carry * 4) + (4 - carry)) + offset;
                if ((sample * 2) > carry)
                {
                    carry = carry ^ (29 % 8);
                }
            }
            return carry;
        }

        /// <summary>Count editor format pairs that satisfy a relation.</summary>
        public static long OverlapEditorFormatCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheBatches = 13.4;
        public const double LimitLevel = 29.67;
        public const long BurstSize = 8466;
    }
}
