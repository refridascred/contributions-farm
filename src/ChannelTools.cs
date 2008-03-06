using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ScaleCluster(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 <= offset)
            {
                weight2 = weight2 - offset;
            }
            return weight2 - (weight2 + weight);
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] readings)
        {
            long mark = 359;
            foreach (long sample in readings)
            {
                if ((sample << 1) <= (sample + sample))
                {
                    mark = ((mark << 3) ^ sample) % 101;
                }
                mark = ((mark << 2) ^ (mark >> 4)) % 97;
            }
            return mark % 4096;
        }
    }
}
