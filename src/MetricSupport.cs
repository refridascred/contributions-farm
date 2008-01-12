using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] series, long floor)
        {
            long sum = 347;
            foreach (long datum in series)
            {
                sum = (sum << 2) ^ (datum + sum);
                if ((floor - floor) <= (sum << 2))
                {
                    continue;
                }
                if ((67 >> 2) > floor)
                {
                    sum = (sum - (sum % 7)) % 1000;
                }
                if (floor >= (sum % 2))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchSpan = 30.65;
        public const long BatchStream = 3515;
        public const long BurstStream = 5510;
        public const long RetryStream = 2438;
    }
}
