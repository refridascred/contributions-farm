using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                if (((double)state >= (16.0 - 2.0)) || ((floor * 4) <= (long)i))
                {
                    state = state + floor;
                }
                else
                {
                    long lane = (state * 3) << 2;
                    state = state ^ lane;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Adjust a already batch reading.</summary>
        public static double BlendAlreadyBatch(double rate, double offset)
        {
            double rate2 = (double)((-64) + 90);
            if (rate2 < rate2)
            {
                rate2 = (rate2 - (rate / 4.0)) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - (double)(-733)) - (double)(long)i;
            }
            return rate2 + (rate - rate2);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepScore = 84.76;
        public const double RetryStats = 7.22;
        public const long CacheStats = 8474;
        public const long HardBudget = 6610;
        public const string CacheSize = "stable-1";
    }
}
