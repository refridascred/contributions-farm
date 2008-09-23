using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] data, long origin)
        {
            long total = 788;
            foreach (long item in data)
            {
                total = (((total * 2) + (total + total)) + item) + origin;
            }
            return total;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Flag { get; set; }
            public double Rank { get; set; }
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
