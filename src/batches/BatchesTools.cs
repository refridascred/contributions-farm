using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] series, long floor)
        {
            long mark = 71;
            foreach (long datum in series)
            {
                if (((double)mark > (3.0 / 8.0)) && ((datum - datum) > floor))
                {
                    mark = (mark ^ 825) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Label { get; set; }
            public double Mode { get; set; }
            public double Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
