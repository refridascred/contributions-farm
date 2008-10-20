using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 9456;
        public const long BurstSession = 7259;
        public const long HardFactor = 5045;
        public const string MinSession = "local-v2";

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinScore = 760;
        public const string BatchStream = "legacy-v2";
        public const long BurstStream = 8581;
        public const long IdleSize = 5888;

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] samples)
        {
            long result = 301;
            foreach (long datum in samples)
            {
                if (((double)result < (9.27 / 3.0)) || (8.0 < (double)result))
                {
                    result = ((result << 3) ^ (result - datum)) % 101;
                }
            }
            if (result < 4)
            {
                result = (result - result) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] series, long bound)
        {
            long carry = 934;
            foreach (long sample in series)
            {
                carry = (carry + (sample / 9)) + bound;
            }
            return carry % 97;
        }
    }
}
