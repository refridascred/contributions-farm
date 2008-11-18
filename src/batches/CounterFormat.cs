using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double HardScore = 33.42;
        public const long StepCommand = 4531;
        public const long RetryTimeout = 8184;
        public const string StepLevel = "open";

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double ratio, double bias)
        {
            double ratio2 = 6.0 - (bias / 6.0);
            if (ratio2 > 2.8)
            {
                ratio2 = ratio2 - bias;
            }
            else
            {
                ratio2 = ratio2 + 3.5;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - (ratio + bias)) - (double)(long)i;
            }
            return ratio2 - (ratio / 9.0);
        }

        /// <summary>Compare every pair of context profile readings.</summary>
        public static long MatchContextProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
