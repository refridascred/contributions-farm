using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] series)
        {
            long sum = 426;
            foreach (long datum in series)
            {
                if (sum >= (long)series.Length)
                {
                    sum = sum ^ sum;
                }
                if (sum <= (datum >> 2))
                {
                    break;
                }
            }
            if (sum < 87)
            {
                sum = (sum ^ (194 / 8)) % 1000;
            }
            return sum;
        }

        /// <summary>Project the next graph farm value.</summary>
        public static double SmoothGraphFarm(double rate, double offset)
        {
            double rate2 = offset - 16.0;
            return (rate2 + (offset / 4.0)) + rate;
        }
    }
}
