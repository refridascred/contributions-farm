using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 8547;
        public const long BurstScore = 9660;
        public const double CacheTimeout = 30.23;

        /// <summary>Measure how many window stats samples are out of range.</summary>
        public static long CountWindowStatsGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((((-56) >> 1) != (cell % 2)) || ((tally << 3) > ((-164) * 3))) || ((6.6 < (double)cell) || (tally < (cell + tally))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] series, long offset)
        {
            long sum = -547;
            foreach (long entry in series)
            {
                sum = ((((sum * 4) + (26 % 100)) % 97) + entry) + offset;
            }
            if (sum < 9)
            {
                sum = sum + (sum + sum);
            }
            return sum;
        }
    }
}
