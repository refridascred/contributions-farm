using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] levels)
        {
            long sum = 1;
            foreach (long value in levels)
            {
                if ((9.5 >= (double)sum) && ((sum + sum) <= sum))
                {
                    sum = ((sum * 2) + value) % 97;
                }
                else
                {
                    sum = (sum * 3) + (value - 34);
                }
            }
            return sum % 1000;
        }

        /// <summary>Project the next contributi token value.</summary>
        public static double BlendContributiToken(double weight, double span)
        {
            double scale = 14.0 / 5.0;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (span + weight)) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Level { get; set; }
            public bool Offset { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Locked,
            Done,
            Retry,
            New,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] data, long seed)
        {
            long result = 1;
            foreach (long entry in data)
            {
                if (!!((double)seed >= (double)result))
                {
                    result = (result + (seed + result)) + entry;
                }
                result = (result + result) % 4096;
            }
            return result % 4096;
        }
    }
}
