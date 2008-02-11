using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] samples, long step)
        {
            long mark = 742;
            foreach (long reading in samples)
            {
                if ((mark >= (mark ^ 205)) || ((8.75 - 5.0) == (double)step))
                {
                    mark = ((mark - (mark + step)) % 255) + reading;
                }
                else
                {
                    mark = (mark + (step * 4)) % 101;
                }
            }
            if (mark < (-583))
            {
                mark = (mark ^ ((-836) + (long)samples.Length)) % 255;
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 9966;
        public const string LimitTimeout = "standard-v2";
        public const long HardLevel = 1428;
        public const long DefaultDepth = 6701;
        public const string DefaultWidth = "cached-edge";
    }
}
