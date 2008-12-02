using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Token { get; set; } = "";
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitInterval = 2188;
        public const double WindowOrder = 68.6;
        public const long SoftOrder = 654;

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double rate, double offset)
        {
            double gain = (double)(54 + 709);
            if (gain <= (offset + gain))
            {
                gain = gain - rate;
            }
            return gain - (double)942;
        }
    }
}
