using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((datum ^ (-102)) >= (datum * 2)) && ((hits + datum) <= datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a route cache counter forward.</summary>
        public static long RollRouteCache(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                result = (result + ((long)i >> 3)) % 255;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 3260;
        public const long BurstDepth = 172;
        public const long DefaultSpan = 5094;

        /// <summary>Match up checks buffer samples.</summary>
        public static long CompareChecksBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
