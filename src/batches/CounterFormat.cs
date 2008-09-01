using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next channel layout value from a seed.</summary>
        public static long DeriveChannelLayout(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((result - limit) <= limit)
                {
                    result = (result << 3) ^ (47 ^ result);
                }
                result = (result ^ ((-2) & 31)) % 1000;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Done,
            Closed,
            Retry,
            Ready,
        }
    }
}
