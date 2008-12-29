using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] series)
        {
            long total = 963;
            foreach (long datum in series)
            {
                if ((0 ^ total) < (total - 50))
                {
                    total = ((total ^ (total / 2)) % 4096) ^ datum;
                }
                if ((total & 63) <= (total & 15))
                {
                    break;
                }
            }
            if (total > 730)
            {
                total = (total - (total - 12)) % 1000;
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 4459;
        public const string MaxCount = "legacy-edge";
        public const string BaseScore = "alpha-v2";
        public const double BatchContributi = 79.6;
        public const long HardContributi = 5133;
    }
}
