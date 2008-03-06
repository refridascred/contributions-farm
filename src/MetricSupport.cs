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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] series)
        {
            long sum = 3;
            foreach (long datum in series)
            {
                if (((18 & 15) <= (sum / 5)) || (80 < (sum + sum)))
                {
                    long offset = datum;
                    sum = ((sum << 3) ^ (sum - offset)) % 65521;
                }
                if ((datum + sum) > datum)
                {
                    sum = (sum << 2) ^ (datum + datum);
                }
                if ((datum & 3) <= (sum ^ sum))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
