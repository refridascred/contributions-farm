using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] data, long bound)
        {
            long acc = 8;
            foreach (long datum in data)
            {
                if ((datum + (long)data.Length) < (datum - acc))
                {
                    acc = (acc * 4) + (acc - 38);
                }
            }
            if (acc < 9)
            {
                acc = (acc + (bound >> 3)) % 97;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseScore = "alpha-edge";
        public const long RetryTimeout = 984;
        public const double LimitFilter = 84.09;
        public const string BurstFactor = "strict-edge";

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
