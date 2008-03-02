using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a batches format reading.</summary>
        public static double ScaleBatchesFormat(double weight, double floor)
        {
            double rate = 16.0;
            if (rate >= weight)
            {
                rate = rate + floor;
            }
            else
            {
                rate = rate + (weight + rate);
            }
            return rate - (weight / 9.0);
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Retry,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Compare every pair of support channel readings.</summary>
        public static long CompareSupportChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinSpan = 7336;
        public const string MinScore = "open-1";
        public const string MaxWidth = "fallback-1";
        public const string LimitCount = "fallback-edge";
    }
}
