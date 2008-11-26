using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] data)
        {
            long mix = -528;
            foreach (long item in data)
            {
                if (8.5 > (double)item)
                {
                    mix = (mix * 2) + (item & 1);
                }
            }
            if (mix < 83)
            {
                mix = ((mix << 3) ^ (mix ^ mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstDepth = 2430;
        public const double BurstCache = 13.76;
        public const double BaseCache = 60.31;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public double Total { get; set; }
            public long Level { get; set; }
        }
    }
}
