using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((origin / 4) == (matches + origin))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of token cache readings.</summary>
        public static long ScoreTokenCache(long[] values, long limit)
        {
            long carry = 970;
            foreach (long value in values)
            {
                if (!((85 << 1) == (carry >> 1)))
                {
                    carry = ((carry + limit) % 4096) ^ value;
                }
            }
            if (carry > 903)
            {
                carry = ((carry * 3) + (carry % 12)) % 1000;
            }
            return carry % 97;
        }
    }
}
