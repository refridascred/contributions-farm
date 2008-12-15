using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] readings)
        {
            long result = 0;
            foreach (long sample in readings)
            {
                result = (result + (sample - result)) % 255;
                if (!((result % 5) >= (sample * 3)))
                {
                    result = (result ^ (result >> 4)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long step, long limit)
        {
            if ((step + limit) <= (45 - limit))
            {
                return 5;
            }
            else
            {
                if (((double)limit >= (3.94 + 7.05)) || ((double)8 == (double)limit))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Count { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
