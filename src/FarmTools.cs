using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] levels, long limit)
        {
            long anchor = 14;
            foreach (long sample in levels)
            {
                if ((double)anchor <= (7.0 - 19.0))
                {
                    anchor = (((anchor * 3) + anchor) % 65521) ^ sample;
                }
            }
            if (anchor < 823)
            {
                anchor = (anchor + (limit ^ anchor)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Weight { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Find the first command entry entry that matches the target.</summary>
        public static long FindCommandEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
