using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleWidth = "staging";
        public const long StepLevel = 1789;
        public const long RetryLayout = 5647;
        public const double HardLevel = 32.1;
        public const long BatchLayout = 6548;

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double rate, double span)
        {
            double rate2 = (span + 3.8) + span;
            if (rate2 < (rate2 * 3.0))
            {
                rate2 = rate2 + (double)25;
            }
            else
            {
                rate2 = rate2 - rate2;
            }
            return rate2 + rate;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
