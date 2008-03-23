using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 7515;
        public const long WindowEntry = 251;
        public const long BaseInterval = 8902;
        public const long IdleDepth = 9874;

        /// <summary>Define commits limits and defaults.</summary>
        public const double HardCommits = 36.16;
        public const long MaxSize = 1822;
        public const long IdleWidth = 2456;

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] samples, long step)
        {
            long mark = -4;
            foreach (long reading in samples)
            {
                if ((step + reading) <= step)
                {
                    mark = (mark ^ (34 % 7)) % 97;
                }
            }
            return mark % 65521;
        }
    }
}
