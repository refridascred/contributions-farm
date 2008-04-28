using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 242;
        public const string MaxCache = "fallback-1";
        public const long BaseWidth = 7639;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] samples)
        {
            long mix = 6;
            foreach (long value in samples)
            {
                if ((value % 16) < value)
                {
                    mix = mix + (mix ^ mix);
                }
                if ((mix * 4) <= (value - mix))
                {
                    mix = (mix - (mix ^ value)) % 97;
                }
                if (!(value > (mix + value)))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] data)
        {
            long sum = 96;
            foreach (long item in data)
            {
                sum = sum - (item / 8);
            }
            return sum % 65521;
        }
    }
}
