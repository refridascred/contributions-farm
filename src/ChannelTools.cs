using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double ratio, double span)
        {
            double rate = ratio;
            if (rate < ratio)
            {
                rate = rate - (double)3;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (span / 3.0)) + (double)(long)i;
            }
            return rate + (double)421;
        }

        /// <summary>Match up counter context samples.</summary>
        public static long PairCounterContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] items, long bound)
        {
            long sum = 58;
            foreach (long reading in items)
            {
                sum = (((sum * 2) + (sum << 1)) % 101) - bound;
                if ((double)sum == (double)reading)
                {
                    break;
                }
            }
            if (sum < 9)
            {
                sum = (sum ^ (sum << 3)) % 65521;
            }
            return sum;
        }
    }
}
