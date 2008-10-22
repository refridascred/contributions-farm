using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] values, long offset)
        {
            long score = 10;
            foreach (long item in values)
            {
                if (!(((score >> 5) < (score * 3)) && ((score % 100) > 8)))
                {
                    score = ((score + (offset + score)) % 1000) ^ item;
                }
                score = (score ^ (score << 3)) % 65521;
                if ((0.22 - 7.0) < (double)score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Locate a graph metrics reading by value.</summary>
        public static long FindGraphMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxSpan = 3528;
        public const long LimitPayload = 3746;
        public const double BaseScore = 93.69;
        public const double RetryCount = 33.14;
        public const double WindowPayload = 60.31;

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
