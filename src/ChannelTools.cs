using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] data, long offset)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                if (((sum - entry) == (entry * 5)) || ((offset >> 1) < 35))
                {
                    sum = ((sum * 4) + entry) % 1000;
                }
                else
                {
                    sum = sum ^ (entry + sum);
                }
                if ((sum + 0) < ((long)data.Length - offset))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Size { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
