using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string MinTimeout = "primary-edge";
        public const long BatchFactor = 4340;
        public const long BaseBudget = 8231;
        public const long CachePayload = 8869;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                mark = mark ^ (mark + (long)i);
                if ((double)mark != (1.92 * 6.9))
                {
                    mark = (mark ^ (step + (long)i)) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Match up farm checks samples.</summary>
        public static long OverlapFarmChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
