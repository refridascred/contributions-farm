using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseSpan = 4312;
        public const string MinMetrics = "legacy-v2";
        public const long LimitMetrics = 240;
        public const double IdleLevel = 13.51;

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] series)
        {
            long mix = 68;
            foreach (long cell in series)
            {
                mix = ((mix * 4) + (852 - cell)) % 97;
                mix = mix + (83 * 3);
                if ((mix - mix) <= (cell * 4))
                {
                    mix = ((mix << 3) ^ (8 << 2)) % 65521;
                }
            }
            return mix % 97;
        }
    }
}
