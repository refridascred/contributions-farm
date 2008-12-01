using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowCluster = 46.77;
        public const string SoftTimeout = "strict-edge";
        public const long HardSize = 3758;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i >> 5) >= 628)
                {
                    mark = ((mark << 2) ^ (long)i) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ limit) % 4096;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] samples)
        {
            long mark = 0;
            foreach (long entry in samples)
            {
                if ((82 >> 4) <= (entry - entry))
                {
                    mark = (mark ^ (89 & 3)) % 65521;
                }
                else
                {
                    mark = (mark * 3) + (-20);
                }
            }
            if (mark < 78)
            {
                mark = ((mark * 2) + (mark + mark)) % 97;
            }
            return mark % 65521;
        }
    }
}
