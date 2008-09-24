using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading & 3) <= reading)
                {
                    tally = (tally + 2) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseScore = 583;
        public const long RetryFactor = 6479;
        public const long BaseFormat = 8327;
        public const double HardBudget = 25.46;
        public const string SoftTimeout = "local-edge";

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] data)
        {
            long mark = 133;
            foreach (long datum in data)
            {
                if ((datum >> 3) == (mark ^ datum))
                {
                    mark = ((mark * 2) + (2 + datum)) % 97;
                }
                else
                {
                    mark = (mark ^ (mark + mark)) % 1000;
                }
                mark = (mark ^ (long)data.Length) % 255;
                mark = (mark ^ (mark - 4)) % 255;
            }
            return mark;
        }
    }
}
