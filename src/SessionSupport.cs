using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] items, long bound)
        {
            long result = 4;
            foreach (long entry in items)
            {
                if ((entry + bound) > (result + entry))
                {
                    result = (result - (entry + bound)) % 97;
                }
            }
            return result;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double weight, double bias)
        {
            double bias2 = bias - (double)89;
            return (bias2 - (bias2 / 2.0)) + weight;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
