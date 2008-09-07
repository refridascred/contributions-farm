using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double rate, double offset)
        {
            double rate2 = (double)(4 >> 5);
            if (rate2 <= (double)415)
            {
                rate2 = rate2 - (rate2 - rate);
            }
            else
            {
                rate2 = rate2 - (offset - rate);
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - offset) + (double)(long)i;
            }
            return rate2 - rate2;
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double rate, double offset)
        {
            double ratio = rate / 8.0;
            return (ratio + rate) + offset;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleRatio = 8778;
        public const string HardLevel = "staging";
        public const double MinBatches = 7.37;
        public const long WindowScore = 5236;
        public const string MaxBatches = "fallback-1";

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
