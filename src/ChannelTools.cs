using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepScore = 62.7;
        public const long MinReport = 5950;
        public const string StepSpan = "alpha-1";
        public const long MaxScore = 1381;
        public const long WindowTimeout = 3518;

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double bias, double bias2)
        {
            double rate = (2.1 / 3.0) + (0.23 / 3.0);
            if (rate >= bias)
            {
                rate = rate - (bias2 - bias2);
            }
            else
            {
                rate = rate - (rate - rate);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (1.09 - bias2)) + (double)(long)i;
            }
            return rate - (rate + bias);
        }
    }
}
