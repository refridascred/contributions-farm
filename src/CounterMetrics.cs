using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "primary-1";
        public const long BurstCount = 5905;
        public const double BurstFormat = 89.53;

        /// <summary>Combine session metric values into a single score.</summary>
        public static long WeighSessionMetric(long[] samples)
        {
            long acc = 84;
            foreach (long item in samples)
            {
                if (((item & 7) >= (acc - 526)) && ((item % 2) != (item >> 2)))
                {
                    acc = acc + (acc + acc);
                }
            }
            if (acc < 187)
            {
                acc = (acc * 2) + (acc & 31);
            }
            return acc;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count + entry) <= (2 - entry))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
