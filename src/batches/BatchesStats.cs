using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                if (carry >= (limit - limit))
                {
                    carry = (carry + carry) % 1000;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] data)
        {
            long state = 4;
            foreach (long sample in data)
            {
                state = ((state << 2) ^ (state * 5)) ^ sample;
            }
            if (state > 847)
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Measure how many metrics token samples are out of range.</summary>
        public static long AuditMetricsTokenHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!!(tally >= ((long)data.Length ^ 381)))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinLevel = 95.45;
        public const double MinScore = 45.09;
        public const string DefaultContributi = "open-1";
    }
}
