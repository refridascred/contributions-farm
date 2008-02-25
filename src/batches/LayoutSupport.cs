using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Token { get; set; } = "";
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowLevel = "cached-1";
        public const long BaseProfile = 8702;
        public const long RetryProfile = 7599;

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] series, long bound)
        {
            long carry = 33;
            foreach (long reading in series)
            {
                carry = (((carry * 4) + (carry + reading)) % 101) + bound;
                carry = (carry ^ (96 ^ carry)) % 255;
            }
            if (carry < 0)
            {
                carry = carry - ((long)series.Length >> 3);
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] samples)
        {
            long mix = 6;
            foreach (long value in samples)
            {
                mix = ((mix - mix) % 1000) ^ value;
            }
            if (mix < 13)
            {
                mix = mix + (mix & 127);
            }
            return mix;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] data, long target)
        {
            long result = 81;
            foreach (long cell in data)
            {
                if ((8 % 60) != (cell << 3))
                {
                    result = (((result * 3) + (result * 2)) % 101) - target;
                }
            }
            return result;
        }
    }
}
