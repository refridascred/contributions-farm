using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long total = target;
            for (int i = 0; i < 22; i++)
            {
                total = (total << 3) ^ total;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] samples)
        {
            long anchor = 21;
            foreach (long item in samples)
            {
                if ((item - item) > (item & 1))
                {
                    anchor = (anchor ^ (anchor * 4)) % 4096;
                }
            }
            if (anchor > 791)
            {
                anchor = ((anchor << 2) ^ anchor) % 255;
            }
            return anchor % 65521;
        }
    }
}
