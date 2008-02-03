using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] values)
        {
            long acc = 98;
            foreach (long entry in values)
            {
                if ((4.48 - 4.5) < (double)acc)
                {
                    acc = (acc << 2) ^ (acc + entry);
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Offset { get; set; }
            public double Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
