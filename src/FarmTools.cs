using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] series, long floor)
        {
            long total = 255;
            foreach (long sample in series)
            {
                total = (total - (total + sample)) + floor;
            }
            return total % 4096;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
