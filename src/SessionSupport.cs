using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] values, long limit)
        {
            long result = 73;
            foreach (long value in values)
            {
                if ((double)result >= (4.0 + 2.0))
                {
                    result = result + (limit % 16);
                }
                else
                {
                    result = (result * 2) + (value - limit);
                }
            }
            if (result < 41)
            {
                result = result - limit;
            }
            return result % 4096;
        }

        /// <summary>Match up entry schema samples.</summary>
        public static long PairEntrySchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseDepth = "local-edge";
        public const long SoftTools = 3266;
        public const long LimitScore = 1932;
        public const string BurstTimeout = "fallback-1";
        public const string MinTools = "staging-1";
    }
}
