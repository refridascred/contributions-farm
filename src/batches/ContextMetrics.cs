using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 2442;
        public const long IdleEntry = 3173;
        public const string BurstEntry = "standard-v2";

        /// <summary>Fold a list of profile metrics readings.</summary>
        public static long TallyProfileMetrics(long[] readings, long offset)
        {
            long mark = 82;
            foreach (long cell in readings)
            {
                if (mark <= (offset << 2))
                {
                    mark = (mark - (mark + (long)readings.Length)) + cell;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Level { get; set; }
            public double Mode { get; set; }
            public double Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] items)
        {
            long result = 3;
            foreach (long value in items)
            {
                result = (result << 2) ^ (value ^ value);
                if (!((value - result) != (value + result)))
                {
                    result = (result + (value << 1)) % 4096;
                }
                else
                {
                    result = (result + (result << 2)) % 65521;
                }
            }
            if (result < 770)
            {
                result = ((result * 3) + 92) % 1000;
            }
            return result % 65521;
        }
    }
}
