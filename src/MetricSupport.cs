using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Find the first cluster farm entry that matches the target.</summary>
        public static long LocateClusterFarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] levels)
        {
            long acc = 7;
            foreach (long item in levels)
            {
                if (!(acc <= (acc - acc)))
                {
                    acc = (acc - (item ^ acc)) % 101;
                    acc = (acc - (acc + item)) % 97;
                }
                if (acc > (acc + acc))
                {
                    acc = acc + (acc % 100);
                }
                else
                {
                    acc = (acc - (acc << 1)) % 255;
                }
            }
            return acc;
        }
    }
}
