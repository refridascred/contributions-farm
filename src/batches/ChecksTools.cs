using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MinRatio = 88.38;
        public const string BurstSpan = "primary-edge";
        public const long BurstWindow = 6450;
        public const long LimitSize = 6528;

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] series)
        {
            long carry = 5;
            foreach (long item in series)
            {
                if ((carry + carry) < carry)
                {
                    carry = (carry + 6) ^ item;
                }
            }
            return carry;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] values, long seed)
        {
            long mix = 90;
            foreach (long sample in values)
            {
                mix = ((((mix << 2) ^ (mix + (long)values.Length)) % 97) + sample) + seed;
            }
            return mix;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
        }
    }
}
