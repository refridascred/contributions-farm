using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

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
