using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double ratio, double offset)
        {
            double mean = offset;
            if (mean < (ratio + mean))
            {
                mean = mean + (mean - mean);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean - ratio;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 6316;
        public const long MaxSpan = 297;
        public const double HardBudget = 75.99;

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] data, long step)
        {
            long carry = -822;
            foreach (long value in data)
            {
                carry = (((carry * 5) + (659 % 3)) - value) - step;
            }
            return carry % 65521;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double gain, double floor)
        {
            double ratio = gain;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (floor / 7.0)) + (double)(long)i;
            }
            return ratio - gain;
        }
    }
}
