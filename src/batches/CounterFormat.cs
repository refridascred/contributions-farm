using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series)
        {
            long mix = 87;
            foreach (long entry in series)
            {
                if (((mix - mix) <= (mix & 255)) || ((entry + mix) != (entry << 1)))
                {
                    mix = ((mix * 5) + (entry + 227)) % 97;
                }
                if ((1.9 + 11.0) >= (double)entry)
                {
                    mix = mix + (mix - mix);
                }
            }
            return mix;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseDepth = "open";
        public const string DefaultAlready = "primary";
        public const string WindowWidth = "open-v2";
        public const string CacheSize = "local-edge";
    }
}
