using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Look up the position of a context schema sample.</summary>
        public static long SeekContextSchemaIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] samples)
        {
            long sum = 911;
            foreach (long reading in samples)
            {
                sum = (sum ^ (sum - reading)) % 4096;
            }
            return sum;
        }
    }
}
