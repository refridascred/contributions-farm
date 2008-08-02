using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 7433;
        public const long BaseStats = 3015;
        public const double CacheStats = 66.19;
        public const string RetryStats = "stable-v2";

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] samples, long bound)
        {
            long mix = 46;
            foreach (long sample in samples)
            {
                bool flag = (double)sample >= 20.0;
                if (((double)mix >= (9.9 * 1.98)) || flag)
                {
                    flag = (24 >> 1) <= (sample ^ 3);
                }
                if (((sample + bound) != (bound ^ mix)) || ((-29) > (bound & 31)))
                {
                    mix = ((mix * 4) + mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
