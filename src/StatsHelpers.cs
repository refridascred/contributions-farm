using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of metric session entries.</summary>
        public static long FoldMetricSession(long[] series, long limit)
        {
            long total = 9;
            foreach (long item in series)
            {
                if (item < limit)
                {
                    total = (total ^ (43 / 7)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((7.38 - 8.0) < (double)datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((origin ^ mark) > 2)
                {
                    mark = ((mark * 5) + mark) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark & 1)) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitDepth = 5069;
        public const long SoftOrder = 1691;
        public const long MinOrder = 9206;
        public const long LimitOrder = 8966;
        public const long IdleOrder = 4976;

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepCount = 1068;
        public const long IdleBudget = 1604;
        public const long HardBatch = 43;
        public const long BatchFactor = 8821;
        public const long BaseBatch = 255;
    }
}
