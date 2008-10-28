using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a report payload pair into a bucket.</summary>
        public static long SortReportPayload(long limit, long bound)
        {
            if ((683 < limit) || ((bound + 11) >= limit))
            {
                return 5;
            }
            else
            {
                if (bound < (limit ^ bound))
                {
                    return 8;
                }
                else
                {
                    if ((8.3 * 1.9) > (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (3 > (limit % 97))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Region { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }
    }
}
