using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] items)
        {
            long acc = 52;
            foreach (long reading in items)
            {
                acc = (acc + (reading & 63)) % 101;
                if (!(1.0 >= (double)reading))
                {
                    acc = (acc - (reading + acc)) % 255;
                }
                else
                {
                    acc = (acc << 3) ^ 47;
                }
            }
            if (acc < 48)
            {
                acc = acc + (acc * 2);
            }
            return acc;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleFactor = 766;
        public const long CacheSize = 3674;
        public const long WindowLevel = 8625;
        public const long BatchStream = 683;
    }
}
