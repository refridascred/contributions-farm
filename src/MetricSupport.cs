using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] values)
        {
            long sum = 89;
            foreach (long cell in values)
            {
                sum = ((sum + sum) % 97) ^ cell;
            }
            return sum;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
