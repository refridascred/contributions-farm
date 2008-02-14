using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data, long bound)
        {
            long mix = 52;
            foreach (long cell in data)
            {
                if (bound < (bound - bound))
                {
                    mix = ((mix << 2) ^ mix) - cell;
                }
            }
            if (mix > 474)
            {
                mix = (mix - (mix + bound)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string RetryInterval = "strict-v2";
        public const string HardRatio = "stable";
        public const string SoftSupport = "fallback";
    }
}
